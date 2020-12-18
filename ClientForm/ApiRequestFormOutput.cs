using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class ApiRequestFormOutput : Form
    {
        ClientForm clientForm;

        public ApiRequestFormOutput(ClientForm cf)
        {
            InitializeComponent();
            clientForm = cf;
        }

        private void ApiRequestFormOutput_Load_1(object sender, EventArgs e)
        {
            comboBoxMethods.DataSource = Enum.GetValues(typeof(HttpMethods));
            txtBoxUrl.Text = clientForm.getUrlOut();
            UpdateListBoxHeaders();
            comboBoxMethods.SelectedItem = clientForm.getMethodOut();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(txtBoxUrl.Text, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (result)
            {
                clientForm.setUrlOut(txtBoxUrl.Text);
                HttpMethods methods;
                Enum.TryParse<HttpMethods>(comboBoxMethods.SelectedValue.ToString(), out methods);
                new ApiRequestFormHandler().UpdateRequest(ToDictionary(clientForm.getHeadersOut()), methods, txtBoxUrl.Text);
                clientForm.setMethodOut(methods);
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
            foreach (LocalHeader h in clientForm.getHeadersOut())
            {
                listBoxHeaders.Items.Add(h);
            }
        }

        private Dictionary<string, string> ToDictionary(List<LocalHeader> localHeaders)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (LocalHeader h in clientForm.getHeadersOut())
            {
                dictionary.Add(h.HeaderName, h.HeaderData);
            }
            return dictionary;
        }

        private void btnAddHeader_Click(object sender, EventArgs e)
        {
            clientForm.addHeaderOut(new LocalHeader(txtBoxHeader.Text, txtBoxHeaderData.Text));
            UpdateListBoxHeaders();
        }

        private void btnRemoveHeader_Click(object sender, EventArgs e)
        {
            clientForm.removeHeaderOut((LocalHeader)listBoxHeaders.SelectedItem);
            UpdateListBoxHeaders();
        }

    }
}
