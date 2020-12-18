using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Xml;

namespace ClientForm
{
    class ExcelHandler : InputType
    {
        public string Location { get; set; }

        public string SheetName { get; set; }

        public ExcelHandler(string _location, string worksheet)
        {
            Location = _location;
            SheetName = worksheet;
        }
        public override Response<string> Run()
        {
            return ExcelToJson(Location);
        }
        public Response<string> ExcelToJson(string excelFileLocation)
        {
            DataSet ds = new DataSet();
            try
            {
                string connectionString = GetConnectionString(excelFileLocation).Data;

                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

                cmd.Connection = conn;

                string ExcelSheetName = SheetName;

                // Updates and sets the query to read all data from the Sheet 
                cmd.CommandText = "SELECT * From [" + ExcelSheetName + "]";
                dataAdapter.SelectCommand = cmd;

                FillSheetData(ds, conn, dataAdapter);

                XmlNode xmlNode = GetXmlNode(ds.GetXml());
                return new Response<string>(JsonConvert.SerializeXmlNode(xmlNode), "Excel -> Json | OK!", STATUS_CODE.OK);
            }
            catch (Exception e)
            {
                return new Response<string>("Unable to Serialize Excel Document: " + excelFileLocation, e.Message, STATUS_CODE.ERROR);
            }
        }

        public Response<string> GetConnectionString(string excelFileLocation)
        {
            string Ext = Path.GetExtension(excelFileLocation);

            if (Ext == ".xls")
            {
                return new Response<string>("Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + excelFileLocation + "; Extended Properties = 'Excel 8.0;HDR=YES'", STATUS_CODE.OK);
            }
            else if (Ext == ".xlsx")
            {
                return new Response<string>("Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + excelFileLocation + "; Extended Properties = 'Excel 8.0;HDR=YES'", STATUS_CODE.OK);
            }
            else
            {
                return new Response<string>("Failed to get the connection string.", STATUS_CODE.ERROR);
            }
        }

        public DataTable getWorkSheets()
        {

            string connectionString = GetConnectionString(Location).Data;

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

            cmd.Connection = conn;
            conn.Open();
            DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            DataTable workSheets = dtSchema;
            conn.Close();
            return workSheets;
        }

        private void FillSheetData(DataSet ds, OleDbConnection conn, OleDbDataAdapter dataAdapter)
        {
            conn.Open();
            dataAdapter.Fill(ds); // Fill Sheet Data to Dataset
            conn.Close();
        }

        private XmlNode GetXmlNode(string dataSetXml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(dataSetXml);
            return xmlDoc.DocumentElement;
        }

        public override string ToString()
        {
            return $"[EXCEL]{Location}";
        }
    }
}