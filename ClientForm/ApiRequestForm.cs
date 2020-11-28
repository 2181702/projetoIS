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
        private Dictionary<string, string> headers;
        public ApiRequestForm()
        {
            InitializeComponent();
            
        }

        private void ApiRequestForm_Load(object sender, EventArgs e)
        {
            comboBoxMethods.DataSource = Enum.GetValues(typeof(HttpMethods));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            new ApiRequestFormHandler().UpdateRequest(headers, (HttpMethods)Enum.Parse(typeof(HttpMethods), comboBoxMethods.SelectedText), txtBoxUrl.Text);
        }
    }

    public enum HttpMethods
    {
        GET, POST, DELETE, PUT
    }
}
