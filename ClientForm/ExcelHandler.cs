using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Xml;

namespace ClientForm
{
    class ExcelHandler
    {

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

                string ExcelSheetName = FetchSheetName(conn);

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

        private Response<string> GetConnectionString(string excelFileLocation)
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

        private string FetchSheetName(OleDbConnection conn)
        {
            conn.Open();
            DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string ExcelSheetName = dtSchema.Rows[0]["TABLE_NAME"].ToString();
            conn.Close();
            return ExcelSheetName;
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

    }
}

/**
//MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0; Data Source = " + excelFileLocation + "; Extended Properties=Excel 8.0;");
//MyCommand.TableMappings.Add("Table", "Product");

OleDbConnection connection;
DataSet dataSet;
OleDbDataAdapter dataAdapter;
XmlHandler xmlHandler = new XmlHandler();
XmlDocument xmlDoc = new XmlDocument();

//MyConnection = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + excelFileLocation + "; Extended Properties = 'Excel 8.0;HDR=YES'");
connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + excelFileLocation + "; Extended Properties = 'Excel 12.0 Xml;HDR=YES'");
dataAdapter = new OleDbDataAdapter("select * from [default]", connection);

dataSet = new DataSet();

MessageBox.Show("EXCEL DATASET FILL");
dataAdapter.Fill(dataSet);
                
MessageBox.Show("EXCEL CONVERSION");
xml = dataSet.GetXml();
xmlDoc.LoadXml(xml);
XmlNode xmlNode = xmlDoc.DocumentElement;
connection.Close();

return new Response<string>(JsonConvert.SerializeXmlNode(xmlNode), "Excel -> Json | OK!", STATUS_CODE.OK);

*/