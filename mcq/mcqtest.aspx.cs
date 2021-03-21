using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace mcq
{
    public partial class mcqtest : System.Web.UI.Page
    {
        private string path;
        private string connectString;
        OleDbConnection cn = new OleDbConnection();
      //  Int32 starttt = Admin1.startt;
        static string scode = "";
        Int16 starttt = 1;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["User_id"] !=null)
            {
               // Response.Write("welcome" + Session["User_id"]);
            }
           
           // Int32 starttt = Admin1.startt;
            if(starttt == 1)
            {
               DropDownList2.Enabled = true;
                Button1.Enabled = true;
            }
            else
            {
                DropDownList2.Enabled = false;

                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
            }
            string str =Login._importantData;

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
            if(starttt == 0)
            {
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
            }
            else
            {
              DropDownList2.Enabled = false;
              Button4.Enabled = true;
            }


            // string scode = "";
            string scode1 = "";
            string scode2 = "";
            Int32 q = 0;
            //

            cn.Open();
            string uid = "2015";
          //  string uid = Session["User_id"].ToString();
            // string ss = "select * from questions where code='" + scode.ToString() + "'";
            //string ss = "select* from questions where code='" + scode.ToString() + "' and not exists(select* from result where Questions.qno=result.qno)";
            string ss = "select *from questions where code='" + scode.ToString() + "'  and not exists(select* from result where Questions.qno=result.qno and result.userid='"+uid+ "')";
            OleDbCommand cmdsearch1 = new OleDbCommand(ss, cn);
            OleDbDataReader reader1 = cmdsearch1.ExecuteReader();
            while (reader1.Read())
            {
                scode1 = reader1["qtitle"].ToString();
                q = Int32.Parse(reader1["qno"].ToString());
            }

            Label4.Text = scode1.ToString();
            if (scode == "NA")
            {
                Button4.Enabled = false;
                Label4.Text = "Invalid subject choice";
                DropDownList2.Enabled = true;
                
            }
            Button1.Enabled = true;
            if(scode !="NA")
            {
                Button1.Enabled = false;
                Button3.Enabled = true;
                DropDownList2.Enabled = false;
            }

            cn.Close();
            reader1.Close();
            //
            //
            cn.Open();
            string sss = "select * from mcq where qno=" + q + "";
            OleDbCommand cmdsearch2 = new OleDbCommand(sss, cn);
            OleDbDataReader reader2 = cmdsearch2.ExecuteReader();
            while (reader2.Read())
            {
                //scode2 = reader2["options"].ToString();
                //q = Int32.Parse(reader2["qno"].ToString());
                DropDownList1.Items.Add(new ListItem(reader2["options"].ToString()));
            }
            //Label4.Text = scode1.ToString();
            cn.Close();
            reader2.Close();
            //  Button1.Enabled = false;
            if (q == 0)
            {
                Button4.Enabled = false;
                Button3.Enabled = false;
                Label4.Text = "Exam has been completed";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if(starttt == 0)
            {
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
            }
            else
            {
               Button2.Enabled = true;
            }
           
           
            //find the question no from question title
            //find the code from question title
            Int32 q=0;
            string c="";
            cn.Open();
            string s = "select * from questions where qtitle='" + Label4.Text.ToString() + "'";
            OleDbCommand cmdsearch = new OleDbCommand(s, cn);
            OleDbDataReader reader = cmdsearch.ExecuteReader();
            while (reader.Read())
            {
                q = Int32.Parse(reader["qno"].ToString());
                c=reader["code"].ToString();
            }
            cn.Close();
            reader.Close();

            //find the answer
            
            cn.Open();
            Int32 answ = 0;
            string qans = "";
            string ss = "select * from answer where qno=" + q + "";
            OleDbCommand cmdsearch1 = new OleDbCommand(ss, cn);
            OleDbDataReader reader1 = cmdsearch1.ExecuteReader();
            while (reader1.Read())
            {
                qans = reader1["ans"].ToString();
            }
            cn.Close();
            reader1.Close();
            //now check user's answer with database
            if (DropDownList1.Text.ToString() == qans)
                answ = 1;
            else
                answ = 0;
            //now save the result to the database
            //think that your default user name is admin.
            //later you must call username from login form
            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            //string uid =  Session["User_id"].ToString();
            string uid = "2015";
            string doe = DateTime.Today.ToString();
            //string doe = DateTime.;
            cmd.CommandText = "insert into result(userid,code,qno,ayesno,dateofexam) values('"+uid+"','"+c+"'," + q + "," + answ + ",'"+doe+"')";
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd22 = new OleDbCommand();
            string all = "select count(userid) as totall from result where userid='" + uid + "' and code='" + scode.ToString() + "'";
            cmd22.CommandText = all;
            cmd22.Connection = cn;
            OleDbDataReader reader3 = cmd22.ExecuteReader();
            while (reader3.Read())
            {
                TextBox1.Text = reader3["totall"].ToString();
            }
            reader3.Close();
            cn.Close();
            Button4.Enabled = false;
            Button1.Enabled = false;
            DropDownList2.Enabled = false;
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(starttt == 0)
            {
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
            }
            else
            {
              DropDownList1.Items.Clear();
               Button4.Enabled = true;
            }
            cn.Open();
            Int32 total = 0;
           // string uid = Session["User_id"].ToString();
            string uid = "2015";
            OleDbCommand cmd22 = new OleDbCommand();
            string all ="select count(code) as totall from result where userid='"+uid+"' and ayesno=1 and code='"+scode.ToString()+"'";
            cmd22.CommandText = all;
            cmd22.Connection = cn;
            OleDbDataReader reader3 = cmd22.ExecuteReader();
            while (reader3.Read())
            {
                total = Int32.Parse(reader3["totall"].ToString());
            }
            reader3.Close();
            cn.Close();
            cn.Open();
        
            //string ss = "select * from questions where code='" + scode.ToString() + "'";
            Int32 qq = 0;
            string scode1 = "";
          //  string uid = Session["User_id"].ToString();
            // string ss = "SELECT Questions.qno, Questions.qtitle, Questions.code FROM Questions WHERE ((Questions.qno)<>(select qno from result where userid='admin'))";
            // string ss = "select Questions.qno,Questions.qtitle *from Questions where not exists(select *from result where Questions.qno=result.qno)";
            //string ss= "select* from questions where code='"+scode.ToString()+"' and not exists(select* from result where Questions.qno=result.qno)";
            string ss = "select* from questions where code='" + scode.ToString() + "'  and not exists(select* from result where Questions.qno=result.qno and result.userid='"+uid+"')";
            OleDbCommand cmdsearch1 = new OleDbCommand(ss, cn);
            OleDbDataReader reader1 = cmdsearch1.ExecuteReader();
            while (reader1.Read())
            {
                scode1 = reader1["qtitle"].ToString();
                qq = Int32.Parse(reader1["qno"].ToString());
            }
            if(qq==0)
            {
                final.Visible = true;
                Label4.Text = "Exam has been completed";
                Button4.Enabled = false;
                Button3.Enabled = false;
                final.Text = "Your currect answer is "+total.ToString();
               
            }
            else
                 Label4.Text = scode1.ToString();
            cn.Close();
            reader1.Close();
            cn.Open();
            Int32 qqq = 0;
            string sss = "select * from mcq where qno=" + qq + "";
            OleDbCommand cmdsearch2 = new OleDbCommand(sss, cn);
            OleDbDataReader reader2 = cmdsearch2.ExecuteReader();
            while (reader2.Read())
            {
                //scode2 = reader2["options"].ToString();
                //q = Int32.Parse(reader2["qno"].ToString());
                DropDownList1.Items.Add(new ListItem(reader2["options"].ToString()));
            }
            //Label4.Text = scode1.ToString();
            cn.Close();
            reader2.Close();
            //Button4.Enabled = true;
            Button2.Enabled = false;
            Button1.Enabled = false;
            DropDownList2.Enabled = false;
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

            cn.Open();
            string s = "select * from subject where title='" + DropDownList2.Text.ToString() + "'";
            OleDbCommand cmdsearch = new OleDbCommand(s, cn);
            OleDbDataReader reader = cmdsearch.ExecuteReader();
            while (reader.Read())
            {
                scode = reader["code"].ToString();
            }
            cn.Close();
            reader.Close();
            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            string t = "select count(qno) as total from questions where code='" + scode + "'";
            cmd.CommandText = t;
            cmd.Connection = cn;
            OleDbDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                TextBox2.Text = rdr["total"].ToString();
            }
            rdr.Close();
            cn.Close();
            cn.Open();
            string uid = "2015";
          //  string uid = Session["User_id"].ToString();
            OleDbCommand cmd22 = new OleDbCommand();
            string all = "select count(userid) as totall from result where userid='"+uid+"' and code='" + scode.ToString() + "'";
            cmd22.CommandText = all;
            cmd22.Connection = cn;
            OleDbDataReader reader3 = cmd22.ExecuteReader();
            while (reader3.Read())
            {
                TextBox1.Text = reader3["totall"].ToString();
            }
            reader3.Close();
            cn.Close();
          

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            DropDownList2.Enabled = false;
            DropDownList1.Items.Clear();
            Label4.Text = "Exam has been Closed";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session.Remove("User_id");
            Response.Redirect("login.aspx");
        }
    }
}