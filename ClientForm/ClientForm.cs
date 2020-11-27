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
                    MessageBox.Show("No Input selected!");
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
    }
}
