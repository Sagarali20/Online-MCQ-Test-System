using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace mcq
{
    public partial class Admin1 : System.Web.UI.Page
    {
        private string path;
        private string connectString;
        OleDbConnection cn = new OleDbConnection();
       // DataSet da = new DataSet();
        static string scode = "";
        static string scode1 = "";
        static Int32 q = 0;
        public static Int32 startt = 0;
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string scode = "";
           // string scode1 = "";
            //Int32 q = 0;
            cn.Open();
            string s="select *from subject Where title='"+ DropDownList1.Text.ToString() +"'";
            OleDbCommand cmdsearch = new OleDbCommand(s, cn);
            OleDbDataReader reader = cmdsearch.ExecuteReader();
            while(reader.Read())
            {
                scode = reader["code"].ToString();
            }
            cn.Close();
            reader.Close();
            cn.Open();
            string ss = "select code,max(qno) as qno from questions group by code having code='" + scode.ToString() + "'";
            OleDbCommand cmdsearch1 = new OleDbCommand(ss, cn);
            OleDbDataReader reader1 = cmdsearch1.ExecuteReader();
            while(reader1.Read())
            {
                scode1 = reader1["qno"].ToString();
            }
            q = Int32.Parse(scode1) + 1;

            TextBox1.Text = q.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            q++;
            TextBox1.Text = q.ToString();
            Button1.Enabled = true;
            Button2.Enabled = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            string s = "insert into questions(qno,qtitle,code) values("+TextBox1.Text+",'"+TextBox2.Text+"','"+scode+"')";
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd1 = new OleDbCommand();
            cmd.Connection = cn;
            string s1 = "insert into mcq(qno,options) values("+TextBox1.Text+",'"+TextBox4.Text+"')";
            cmd.CommandText = s1;
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd2 = new OleDbCommand();
            cmd.Connection = cn;
            string s2 = "insert into mcq(qno,options) values(" + TextBox1.Text + ",'" + text2.Text + "')"; ;
            cmd.CommandText = s2;
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd3 = new OleDbCommand();
            cmd.Connection = cn;
            string s3 = "insert into mcq(qno,options) values(" + TextBox1.Text + ",'" + TextBox5.Text + "')"; ;
            cmd.CommandText = s3;
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd4 = new OleDbCommand();
            cmd.Connection = cn;
            string s4 = "insert into mcq(qno,options) values(" + TextBox1.Text + ",'" + TextBox6.Text + "')"; ;
            cmd.CommandText = s4;
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd5 = new OleDbCommand();
            cmd.Connection = cn;
            string s5 ="insert into answer(qno,ans) values("+TextBox1.Text+",'"+TextBox7.Text+"') ";
            cmd.CommandText = s5;
            cmd.ExecuteNonQuery();
            cn.Close();
            Button2.Enabled = true;
            Button8.Enabled = false;
            Button5.Enabled = false;
            Button1.Enabled = false;


        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            startt++;
            Button7.Enabled = true;
            Button6.Enabled = false;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            startt = 0;
            Button6.Enabled = true;
            Button7.Enabled = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            cn.Open();
            string qtitle = "";

            OleDbCommand cmd5 = new OleDbCommand();
            string s5 = "select *from questions where qno="+TextBox1.Text+" and code='"+scode+"'";
            cmd5.CommandText = s5;
            cmd5.Connection = cn;
            OleDbDataReader reader = cmd5.ExecuteReader();
            if(reader.Read())
            {
                qtitle = reader["qtitle"].ToString();
                Label2.Text = "Qestion has been found";
            }
            else
            {
                Label2.Text = "Question not found";
            }
            TextBox2.Text = qtitle.ToString();
            reader.Close();
            cn.Close();
            cn.Open();
            //string qtitle = "";
            // Int32 q = 0;
            OleDbCommand cmd6 = new OleDbCommand();
            string s7 = "select *from mcq where qno ="+TextBox1.Text+"";
            cmd6.CommandText = s7;
            cmd6.Connection = cn; 
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd6;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count > 0)
            {
                TextBox4.Text = ds.Tables[0].Rows[0]["options"].ToString();
                text2.Text = ds.Tables[0].Rows[1]["options"].ToString();
                TextBox5.Text = ds.Tables[0].Rows[2]["options"].ToString();
                TextBox6.Text = ds.Tables[0].Rows[3]["options"].ToString();
            }
            cn.Close();
            cn.Open();
            string ans = "";
            OleDbCommand cmd7 = new OleDbCommand();
            String s6 = "select *from answer where qno=" + TextBox1.Text + "";
            cmd7.CommandText = s6;
            cmd7.Connection = cn;
            OleDbDataReader reader1 = cmd7.ExecuteReader();
            if(reader1.Read())
            {
                ans = reader1["ans"].ToString();
                TextBox7.Text = ans.ToString();
            }
            cn.Close();
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button9.Enabled = true;
            Button8.Enabled = false;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Int32 anslno = 0;
            OleDbCommand cmd6 = new OleDbCommand();
            string s7 = "select *from mcq where qno =" + TextBox1.Text + "";
            cmd6.CommandText = s7;
            cmd6.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd6;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                anslno = Int32.Parse(ds.Tables[0].Rows[0]["aslno"].ToString());
            }
            cn.Close();
            cn.Open();
            OleDbCommand cmd8 = new OleDbCommand();
            string s8="update questions set qtitle='"+TextBox2.Text+"' where qno="+TextBox1.Text+"";
            cmd8.CommandText = s8;
            cmd8.Connection = cn;
            cmd8.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd9 = new OleDbCommand();
            string s9 = "update  mcq set options='" +TextBox4.Text+ "' where aslno=" +anslno+ "";
            anslno++;
            cmd9.CommandText = s9;
            cmd9.Connection = cn;
            cmd9.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd10 = new OleDbCommand();
            string s10 = "update  mcq set options='" +text2.Text+ "' where aslno=" + anslno + "";
            anslno++;
            cmd10.CommandText = s10;
            cmd10.Connection = cn;
            cmd10.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd11 = new OleDbCommand();
            string s11 = "update  mcq set options='" + TextBox5.Text + "' where aslno=" + anslno + "";
            anslno++;
            cmd11.CommandText = s11;
            cmd11.Connection = cn;
            cmd11.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd12 = new OleDbCommand();
            string s12 = "update  mcq set options='" + TextBox6.Text + "' where aslno=" + anslno + "";
            anslno++;
            cmd12.CommandText = s12;
            cmd12.Connection = cn;
            cmd12.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd13 = new OleDbCommand();
            string s13 = "update answer set ans='" + TextBox7.Text + "' where qno=" + TextBox1.Text + "";
            cmd13.CommandText = s13;
            cmd13.Connection = cn;
            cmd13.ExecuteNonQuery();
            cn.Close();
            Button3.Enabled = false;
            Button4.Enabled = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            cn.Open();
            OleDbCommand cmd14 = new OleDbCommand();
            string s15 = "delete from mcq where qno=" + TextBox1.Text + "";
            cmd14.CommandText = s15;
            cmd14.Connection = cn;
            cmd14.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd16 = new OleDbCommand();
            string s16 = "delete from answer where qno=" + TextBox1.Text + "";
            cmd16.CommandText = s16;
            cmd16.Connection = cn;
            cmd16.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            OleDbCommand cmd13 = new OleDbCommand();
            string s14 = "Delete from questions where qno=" + TextBox1.Text + "";
            cmd13.CommandText = s14;
            cmd13.Connection = cn;
            cmd13.ExecuteNonQuery();
            cn.Close();
            Button4.Enabled = false;
            Button3.Enabled = false;


        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Button8.Enabled = false;
            Button1.Enabled = true;
            Button9.Enabled = true;
            Button5.Enabled = false;
            Button4.Enabled = false;
            Button3.Enabled = false;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Button5.Enabled = true;
            Button8.Enabled = true;
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button9.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            
        }
    }
}