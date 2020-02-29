using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Login : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlConnection con = new SqlConnection();
    SqlDataAdapter ada = new SqlDataAdapter();
    DataSet ds = new DataSet();
   

    protected void Page_Load(object sender, EventArgs e)
    {
      

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        String a = ConfigurationManager.ConnectionStrings["res"].ToString();
        SqlConnection con = new SqlConnection(a);
        con.Open();      

        cmd.CommandText="select * from Register where username='"+TextBox1.Text+"'and password='"+TextBox2.Text+"'";
        cmd.Connection=con;
        ada.SelectCommand=cmd;
        ada.Fill(ds,"Register");  
      
        if(ds.Tables [0].Rows.Count>0)
        {            
            Label6.Text="Login Successful";
            Session["wel"] = "WelCome :  "+TextBox1.Text;     
            Response.Redirect("Home.aspx");            
        }
        else
        {
            Label6.Text="Invalid User";
        }
    }   
       
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
       
    }
}