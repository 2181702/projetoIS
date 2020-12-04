using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class ClientForm : Form
    {
        private FlowHandler flowHandler;

        private HttpRequestMessage tempInputMessage;
        private HttpRequestMessage tempOutputMessage;

        private String url = "";
        private List<LocalHeader> headers = new List<LocalHeader>();
        private HttpMethods method = HttpMethods.GET;

        public ClientForm()
        {
            InitializeComponent();
            flowHandler = new FlowHandler(this, new FlowFileHandler());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddFlow_Click(object sender, EventArgs e)
        {
            InputType input;
            switch(GetSelectedInput())
            {
                case DataType.EXCEL:
                    input = new ExcelHandler(textBoxInputExcel.Text);
                    break;
                case DataType.REST:
                    input = new RestApiHandlerInput(tempInputMessage);
                    break;
                case DataType.XML:
                    input = new XmlHandlerInput(textBoxInputXml.Text);
                    break;
                default:
                    MessageBox.Show("No Input selected!");
                    return;
            }
            OutputType output;
            switch (GetSelectedOutput())
            {
                case DataType.HTML:
                    output = new HtmlHandler(textBoxOutputHtml.Text);
                    break;
                case DataType.REST:
                    output = new RestApiHandlerOutput(tempOutputMessage);
                    break;
                case DataType.XML:
                    output = new XmlHandlerOutput(textBoxOutputXml.Text);
                    break;
                default:
                    MessageBox.Show("No Output selected!");
                    return;
            }
            flowHandler.AddFlow(new Flow(input,output));
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

        internal void UpdateSavedFlows()
        {
            listBoxSavedFlows.Items.Clear();
            foreach (Flow f in flowHandler.GetFlows())
            {
                listBoxSavedFlows.Items.Add(f);
            }
        }


        internal void ShowMessage(string text)
        {
            MessageBox.Show(text);
        }

        internal bool AskMessage(string title, string message)
        {
            DialogResult dialogResult = MessageBox.Show(message,title, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            return false;
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
            if (radioOutputXml.Checked)
            {
                return DataType.XML;
            }
            return DataType.UNDEFINED;
        }

        private void buttonOpenExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Worksheets| *.xls;*.xlsx";
            openFileDialog.ShowDialog();
            textBoxInputExcel.Text = openFileDialog.FileName;
        }

        private void buttonOpenXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files| *.xml";
            openFileDialog.ShowDialog();
            textBoxInputXml.Text = openFileDialog.FileName;
        }

        private void buttonSaveHtml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "HTML Documents| *.html";
            openFileDialog.ShowDialog();
            textBoxOutputHtml.Text = openFileDialog.FileName;
        }

        private void btnOutputXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files| *.xml";
            openFileDialog.ShowDialog();
            textBoxOutputXml.Text = openFileDialog.FileName;
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
                //Uncomment this lines to see server response [DEBUG purposes]
            }
            if (numErrors == 0)
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
            try { 
                var flow = listBoxSavedFlows.SelectedItem;
                if(!listBoxFlowsToRun.Items.Contains(flow))
                    listBoxFlowsToRun.Items.Add(flow);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nNo Flow Selected!");
            }
        }

        private void buttonDeleteRun_Click(object sender, EventArgs e)
        {
            listBoxFlowsToRun.Items.Remove(listBoxFlowsToRun.SelectedItem);
        }

        private void buttonDeleteSaved_Click(object sender, EventArgs e)
        {
            flowHandler.RemoveFlow((Flow)listBoxSavedFlows.SelectedItem);
        }

        private void btnOutputRest_Click(object sender, EventArgs e)
        {
            Response<HttpRequestMessage> response = new ApiRequestFormHandler(this).GetRestRequest();
            if(response.Status == STATUS_CODE.OK)
            {
                textBoxOutputRest.Text = response.Data.RequestUri.ToString();
                tempOutputMessage = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void btnInputRest_Click(object sender, EventArgs e)
        {
            Response<HttpRequestMessage> response = new ApiRequestFormHandler(this).GetRestRequest(); 
            if (response.Status == STATUS_CODE.OK)
            {   
                textBoxInputRest.Text = "["+response.Data.Method.ToString()+"] "+response.Data.RequestUri.ToString();
                tempInputMessage = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }

        }

        private void buttonExportFlows_Click(object sender, EventArgs e)
        {
            flowHandler.SaveFlows();
        }

        private void buttonImportFlows_Click(object sender, EventArgs e)
        {
            flowHandler.LoadSavedFlows();
        }

        public String getUrl()
        {
            return url;
        }

        public void setUrl(String url)
        {
           this.url = url;
        }

        public HttpMethods getMethod()
        {
            return this.method;
        }

        public void setMethod(HttpMethods method)
        {
            this.method = method;
        }


        public List<LocalHeader> getHeaders()
        {
            return new List<LocalHeader>(headers);
        }

        public void addHeader(LocalHeader header)
        {
            if (header != null && !this.headers.Contains(header))
            {
                this.headers.Add(header);
            }
        }

        public void removeHeader(LocalHeader header)
        {
            if (header != null && this.headers.Contains(header))
            {
                this.headers.Remove(header);
            }
        }
    }
}
