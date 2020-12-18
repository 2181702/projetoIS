using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class ApiRequestFormInput : Form
    {
        ClientForm clientForm;

        public ApiRequestFormInput(ClientForm cf)
        {
            InitializeComponent();
            clientForm = cf;
        }

        private void ApiRequestForm_Load(object sender, EventArgs e)
        {
            comboBoxMethods.DataSource = Enum.GetValues(typeof(HttpMethods));
            txtBoxUrl.Text = clientForm.getUrlIn();
            UpdateListBoxHeaders();
            comboBoxMethods.SelectedItem = clientForm.getMethodIn();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(txtBoxUrl.Text, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (result)
            {
                clientForm.setUrlIn(txtBoxUrl.Text);
                HttpMethods methods;
                Enum.TryParse<HttpMethods>(comboBoxMethods.SelectedValue.ToString(), out methods);
                new ApiRequestFormHandler().UpdateRequest(ToDictionary(clientForm.getHeadersIn()), methods, txtBoxUrl.Text);
                clientForm.setMethodIn(methods);
                Close();
            }
            else
            {
                MessageBox.Show("Invalid URL");
            }
        }

        private void btnAddHeader_Click(object sender, EventArgs e)
        {
            clientForm.addHeaderIn(new LocalHeader(txtBoxHeader.Text, txtBoxHeaderData.Text));
            UpdateListBoxHeaders();

        }

        private void btnRemoveHeader_Click(object sender, EventArgs e)
        {
            clientForm.removeHeaderIn((LocalHeader)listBoxHeaders.SelectedItem);
            UpdateListBoxHeaders();
        }

        private void UpdateListBoxHeaders()
        {
            listBoxHeaders.Items.Clear();
            foreach (LocalHeader h in clientForm.getHeadersIn())
            {
                listBoxHeaders.Items.Add(h);
            }
        }

        private Dictionary<string, string> ToDictionary(List<LocalHeader> localHeaders)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (LocalHeader h in clientForm.getHeadersIn())
            {
                dictionary.Add(h.HeaderName, h.HeaderData);
            }
            return dictionary;
        }
    }
}
