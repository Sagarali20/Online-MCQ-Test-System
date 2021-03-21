using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace mcq
{
    public partial class Registeration : System.Web.UI.Page
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
            protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            if(password1.Text != password2.Text)
            {
                Label1.Text = "Password doesn't matched, please check and try again.";
            }
            else
            {
                cmd.CommandText = "INSERT INTO registeration(Name,Address,Phone,Email,Gender,Age,Department,UserName,ppassword) VALUES('" + TextBox1.Text.ToString() + "','" + TextBox2.Text.ToString() + "'," + TextBox3.Text.ToString() + ",'" + TextBox4.Text.ToString() + "','" + RadioButtonList1.Text.ToString() + "'," + TextBox6.Text.ToString() + ",'"+ TextBox7.Text.ToString() + "','"+ TextBox8.Text.ToString() + "'," + password1.Text.ToString() + ")";
                cmd.ExecuteNonQuery();
                cn.Close();
                Label1.Text = "Registeration has been successfull !";

            }

            //  cmd.ExecuteNonQuery();
            //  cn.Close();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}