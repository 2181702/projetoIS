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
    public partial class ApiRequestForm : Form
    {
        ClientForm clientForm;
        HttpRequestMessage PreviousMessage;

        public ApiRequestForm(ClientForm cf)
        {
            InitializeComponent();
            
        }

        private void ApiRequestForm_Load(object sender, EventArgs e)
        {
            if (clientForm.IsItInput())
            {
                PreviousMessage = clientForm.getTempInputRequest();
            }
            else
            {
                PreviousMessage = clientForm.getTempOutputRequest();
            }
            comboBoxMethods.DataSource = Enum.GetValues(typeof(HttpMethods));
            if(PreviousMessage != null)
            {
                txtBoxUrl.Text = PreviousMessage.RequestUri.ToString();
                UpdateListBoxHeaders();
                comboBoxMethods.SelectedItem = clientForm.getMethod();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(txtBoxUrl.Text, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (result)
            {
                HttpMethods methods;
                Enum.TryParse<HttpMethods>(comboBoxMethods.SelectedValue.ToString(), out methods);
                new ApiRequestFormHandler().UpdateRequest(ToDictionary(), methods, txtBoxUrl.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Invalid URL");
            }
        }

        private void UpdateListBoxHeaders()
        {
            listBoxHeaders.Items.Clear();
            foreach (LocalHeader h in headers)
            {
                listBoxHeaders.Items.Add(h);
            }
        }

        private Dictionary<string,string> ToDictionary(List<LocalHeader> localHeaders)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach(LocalHeader h in headers)
            {
                dictionary.Add(h.HeaderName,h.HeaderData);
            }
            return dictionary;
        }
        /**
         * Ideally the headers list would be a dictionary, but that doesn't work well with the listbox, so I made it a list
         * But a list only has one type, so I made the localheader type to hold two strings, and in the end, it will return a dictionary with the ToDictionary method
         */
        private class LocalHeader
        {
            public string HeaderName { get; set; }
            public string HeaderData { get; set; }

            public LocalHeader(string name, string data)
            {
                HeaderName = name;
                HeaderData = data;
            }

            public override string ToString()
            {
                return "[" + HeaderName + "]" + HeaderData;
            }
        }

        private void btnRemoveHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnAddHeader_Click(object sender, EventArgs e)
        {

        }
    }

    /**
     * an enum just to work better with the combobox
     */
    public enum HttpMethods
    {
        GET, POST, DELETE, PUT
    }
}
