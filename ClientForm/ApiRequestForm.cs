using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientForm
{   
    public partial class ApiRequestForm : Form
    {
        ClientForm clientForm;

        public ApiRequestForm(ClientForm cf)
        {
            InitializeComponent();
            clientForm = cf;
        }

        private void ApiRequestForm_Load(object sender, EventArgs e)
        {
            comboBoxMethods.DataSource = Enum.GetValues(typeof(HttpMethods));
            txtBoxUrl.Text = clientForm.getUrl();
            UpdateListBoxHeaders();
            comboBoxMethods.SelectedItem = clientForm.getMethod();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(txtBoxUrl.Text, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (result)
            {
                clientForm.setUrl(txtBoxUrl.Text);
                HttpMethods methods;
                Enum.TryParse<HttpMethods>(comboBoxMethods.SelectedValue.ToString(), out methods);
                new ApiRequestFormHandler().UpdateRequest(ToDictionary(clientForm.getHeaders()), methods, txtBoxUrl.Text);
                clientForm.setMethod(methods);
                Close();
            }
            else
            {
                MessageBox.Show("Invalid URL");
            }
        }

        private void btnAddHeader_Click(object sender, EventArgs e)
        {
            clientForm.addHeader(new LocalHeader(txtBoxHeader.Text, txtBoxHeaderData.Text));
            txtBoxHeader.Text = "";
            txtBoxHeaderData.Text = "";
            UpdateListBoxHeaders();
            
        }

        private void btnRemoveHeader_Click(object sender, EventArgs e)
        {
            clientForm.removeHeader((LocalHeader)listBoxHeaders.SelectedItem);
            UpdateListBoxHeaders();
        }

        private void UpdateListBoxHeaders()
        {
            listBoxHeaders.Items.Clear();
            foreach (LocalHeader h in clientForm.getHeaders())
            {
                listBoxHeaders.Items.Add(h);
            }
        }

        private Dictionary<string,string> ToDictionary(List<LocalHeader> localHeaders)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach(LocalHeader h in clientForm.getHeaders())
            {
                dictionary.Add(h.HeaderName,h.HeaderData);
            }
            return dictionary;
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
