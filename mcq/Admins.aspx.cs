using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace mcq
{
    public partial class Admin : System.Web.UI.Page
    {
        private string path;
        private string connectString;
        OleDbConnection cn = new OleDbConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Microsoft.ACE.OLEDB.12.0
            //Microsoft.Jet.OLEDB.4.0
            //"Data Source=C:\\Users\\user\\Documents\\Visual Studio 2012\\Projects\\registration\\registration\\App_Data\\userdata.accdb";
            path = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            connectString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + path + "\\mcq.accdb";
            //Create an OleDbConnection object, 
            //and then pass in the ConnectionString to the constructor.
            cn.ConnectionString = connectString;
            //OleDbConnection cn = new OleDbConnection(connectString);
            //Open the connection.
            //cn.Open();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
             string scode = "";
            string scode1 = "";
            string scode2 = "";
            Int32 q = 0;
            cn.Open();
            string s = "select * from subject where title='" + DropDownList1.Text.ToString() + "'";
            OleDbCommand cmdsearch = new OleDbCommand(s, cn);
            OleDbDataReader reader = cmdsearch.ExecuteReader();
            while (reader.Read())
            {
                scode = reader["code"].ToString();
            }
            cn.Close();
            reader.Close();
            //

            cn.Open();
            string ss = "select * from questions where code='" + scode.ToString() + "'";
            OleDbCommand cmdsearch1 = new OleDbCommand(ss, cn);
            OleDbDataReader reader1 = cmdsearch1.ExecuteReader();
            while (reader1.Read())
            {
                scode1 = reader1["qtitle"].ToString();
                q = Int32.Parse(reader1["qno"].ToString());
            }
           // Label4.Text = scode1.ToString();
            cn.Close();
            reader1.Close();
        }
    }
}