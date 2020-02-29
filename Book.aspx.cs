using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Book : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlConnection con = new SqlConnection();
    SqlDataAdapter sda = new SqlDataAdapter();
    DataSet ds = new DataSet();
    IDataReader dr;

    protected void Page_Load(object sender, EventArgs e)

    {
        
        Label8.Text = Session["moviename"].ToString();
        String a = ConfigurationManager.ConnectionStrings["movie"].ToString();
        SqlConnection con = new SqlConnection(a);
        con.Open();

        if (!IsPostBack)
        {
            SqlCommand cmd = new SqlCommand("Select distinct city from movie", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
        if (!IsPostBack)
        {
            DropDownList2.Text = "";
            SqlDataReader dr1 = null;
            SqlCommand cmd = new SqlCommand("Select theatre from movie", con);
            dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                DropDownList2.Items.Add(dr1[0].ToString());
            }
        }
        



    }
    

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
     
    }


    protected void Button1_Click(object sender, EventArgs e)
    {


        Session["date"] = TextBox1.Text;
        Session["city"] = DropDownList1.Text;
        Session["theater"] = DropDownList2.Text;


        if (RadioButton1.Checked == true)
        {
            Session["time"] = RadioButton1.Text;
        }

        else if (RadioButton2.Checked == true)
        {
            Session["time"] = RadioButton2.Text;
        }

        else if (RadioButton3.Checked == true)
        {
            Session["time"] = RadioButton3.Text;
        }
        else
        {
            Session["time"] = RadioButton4.Text;
        }


        Session["date"] = TextBox1.Text;
        Response.Redirect("ConfirmBook.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}