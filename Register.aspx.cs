using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        String a = ConfigurationManager.ConnectionStrings["res"].ToString();
        SqlConnection con = new SqlConnection(a);
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into Register" + "(username,password,confirmpassword,phone)values(@username,@password,@confirmpassword,@phone)", con);

        cmd.Parameters.AddWithValue("@username", TextBox1.Text);
        cmd.Parameters.AddWithValue("@password", TextBox2.Text);
        cmd.Parameters.AddWithValue("@confirmpassword", TextBox3.Text);
        cmd.Parameters.AddWithValue("@phone", TextBox4.Text);
        cmd.ExecuteNonQuery();
        Label8.Text = "Registration Successful";
        if (Label8.Text != "")
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
     }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}