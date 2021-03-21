using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace mcq
{
    public partial class Result : System.Web.UI.Page
    {
        private string path;
        private string connectString;
        OleDbConnection cn = new OleDbConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
          //  SqlConnection cn= new SqlConnection("Data Source=SOBUJ\\SQLEXPRESS;Initial Catalog=RegistredCustomer;User Id=sa;Password= ;Integrated Security=True");

            //Microsoft.ACE.OLEDB.12.0
            //Microsoft.Jet.OLEDB.4.0
          //  "Data Source=C:\\Users\\user\\Documents\\Visual Studio 2012\\Projects\\registration\\registration\\App_Data\\userdata.accdb";
               path = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
              connectString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + path + "\\mcq.accdb";
            //Create an OleDbConnection object, 
            //and then pass in the ConnectionString to the constructor.
             cn.ConnectionString = connectString;
            //OleDbConnection cn = new OleDbConnection(connectString);
            //Open the connection.
            //cn.Open();
            cn.Open();
           // SqlCommand cmd = new SqlCommand();
            OleDbCommand cmd = new OleDbCommand();
            string s = "select userid,code as Subject,count(code) as Right_answer from result where ayesno=1 and code='IP' group by userid,code order by Right_answer desc";
            cmd.CommandText = s; 
            cmd.Connection = cn;
             OleDbDataAdapter da = new OleDbDataAdapter();
           // SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            cn.Close();
        }
    }
    
}