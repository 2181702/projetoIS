using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class ClientForm : Form
    {
        private FlowHandler flowHandler;
        public ClientForm()
        {
            InitializeComponent();
            flowHandler = new FlowHandler(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddFlow_Click(object sender, EventArgs e)
        {
            Flow flow = new Flow();
            switch(GetSelectedInput())
            {
                case DataType.EXCEL:
                    flow.InputType = DataType.EXCEL;
                    flow.InputLocation = textBoxInputExcel.Text;
                    break;
                case DataType.REST:
                    flow.InputType = DataType.REST;
                    flow.InputLocation = textBoxInputRest.Text;
                    break;
                case DataType.XML:
                    flow.InputType = DataType.XML;
                    flow.InputLocation = textBoxInputXml.Text;
                    break;
                default:
                    MessageBox.Show("No Input selected!");
                    return;
            }
            switch (GetSelectedOutput())
            {
                case DataType.HTML:
                    flow.OutputType = DataType.HTML;
                    flow.OutputLocation = textBoxOutputHtml.Text;
                    break;
                case DataType.REST:
                    flow.OutputType = DataType.REST;
                    flow.OutputLocation = textBoxOutputRest.Text;
                    break;
                default:
                    MessageBox.Show("No Output selected!");
                    return;
            }
            flowHandler.AddFlow(flow);
        }

        internal void UpdateExistingFlows()
        {
            listBoxSavedFlows.Items.Clear();
            foreach (Flow f in flowHandler.GetFlows())
            {
                listBoxSavedFlows.Items.Add(f);
            }
        }

        private DataType GetSelectedInput()
        {
            if (radioInputExcel.Checked)
            {
                return DataType.EXCEL;
            }
            if (radioInputXML.Checked)
            {
                return DataType.XML;
            }
            if (radioInputRest.Checked)
            {
                return DataType.REST;
            }
            return DataType.UNDEFINED;
        }

        private DataType GetSelectedOutput()
        {
            if (radioOutputHtml.Checked)
            {
                return DataType.HTML;
            }
            if (radioOutputRest.Checked)
            {
                return DataType.REST;
            }
            return DataType.UNDEFINED;
        }

        private void buttonOpenExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            textBoxInputExcel.Text = openFileDialog.FileName;
        }

        private void buttonOpenXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            textBoxInputXml.Text = openFileDialog.FileName;
        }

        private void buttonSaveHtml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            textBoxOutputHtml.Text = openFileDialog.FileName;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Response<string> response = new Response<string>();
            int numErrors = 0;
            int numFlows = listBoxFlowsToRun.Items.Count;
            foreach(Flow f in listBoxFlowsToRun.Items)
            {
                response = f.Run();
                if(response.Status != STATUS_CODE.OK)
                {
                    numErrors++;
                    if (!DealWithResponse(response))
                        break;
                }
            }
            if(numErrors == 0)
            {
                MessageBox.Show("All flows runned successfully!");
            }
            else
            {
                MessageBox.Show(numFlows - numErrors + " Flows runned out of " + numFlows);
            }
        }

        private bool DealWithResponse(Response<string> response)
        {
            bool returnable = true;
            switch (response.Status)
            {
                case STATUS_CODE.ERROR:
                    DialogResult dialogResult = MessageBox.Show(response.Message + "\n Want to continue the other flows?", "Error!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        returnable = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        returnable = false;
                    }
                    MessageBox.Show(response.Message);
                    break;
            }
            return returnable;
        }

        private void buttonAddToRun_Click(object sender, EventArgs e)
        {
            var flow = listBoxSavedFlows.SelectedItem;
            if(!listBoxFlowsToRun.Items.Contains(flow))
                listBoxFlowsToRun.Items.Add(flow);
        }

        private void buttonDeleteRun_Click(object sender, EventArgs e)
        {
            listBoxFlowsToRun.Items.Remove(listBoxFlowsToRun.SelectedItem);
        }

        private void buttonDeleteSaved_Click(object sender, EventArgs e)
        {
            flowHandler.RemoveFlow((Flow)listBoxSavedFlows.SelectedItem);
        }
    }
}
