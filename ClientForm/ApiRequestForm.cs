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
        public ApiRequestForm()
        {
            InitializeComponent();
            
        }

        private void ApiRequestForm_Load(object sender, EventArgs e)
        {
            comboBoxMethods.DataSource = Enum.GetValues(typeof(HttpMethods));
        }
    }

    public enum HttpMethods
    {
        GET, POST, DELETE, PUT
    }
}
