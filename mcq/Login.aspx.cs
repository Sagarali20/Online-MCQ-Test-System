using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace mcq
{
    public partial class Login : System.Web.UI.Page
    {
        private string path;
        private string connectString;
        OleDbConnection cn = new OleDbConnection();
        public static string sagar;
        public static string _importantData;
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
            _importantData = "sagar ali";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            string s = "Select *from Registeration where UserName='" + TextBox1.Text + "' and ppassword=" + TextBox2.Text + "";
            cmd.CommandText = s;
            OleDbDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                Session["User_id"] = TextBox1.Text;
                Response.Redirect("mcqtest.aspx");
            }
            else
            {
                Label1.Text = "Invalid User/Password";
                HyperLink1.Visible = true;
            }
            reader.Close();
            cn.Close();
 
        }
    }
}