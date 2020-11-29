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
        private String xml;

        public Response<string> ExcelToJson(string excelFileLocation)
        {
            DataSet ds = new DataSet();
            try
            {
                string Ext = Path.GetExtension(excelFileLocation);
                string connectionString = "";
                if (Ext == ".xls")
                {
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + excelFileLocation + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                else if (Ext == ".xlsx")
                {
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + excelFileLocation + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

                cmd.Connection = conn;

                //Fetch Fisrt Sheet Name  
                conn.Open();
                DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string ExcelSheetName = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();

                //Read all data from the Sheet to a Data Table  
                conn.Open();
                cmd.CommandText = "SELECT * From [" + ExcelSheetName + "]";
                dataAdapter.SelectCommand = cmd;

                dataAdapter.Fill(ds); // Fill Sheet Data to Dataset
                conn.Close();

                XmlDocument xmlDoc = new XmlDocument();
                xml = ds.GetXml();
                xmlDoc.LoadXml(xml);
                XmlNode xmlNode = xmlDoc.DocumentElement;

                return new Response<string>(JsonConvert.SerializeXmlNode(xmlNode), "Excel -> Json | OK!", STATUS_CODE.OK);
            }
            catch (Exception e)
            {
                return new Response<string>("Unable to Serialize Excel Document: " + excelFileLocation, e.Message, STATUS_CODE.ERROR);
            }
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