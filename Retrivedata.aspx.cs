using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Retrivedata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["wel"] != null)
        {
            GridView2.Visible = true;

            Label4.Text = "Booked Tickets";
            LinkButton2.Visible = false;
            
        }
        else
        {
            GridView2.Visible = false;

            Label4.Text = "Please Login to show the Booked Tickets";
            LinkButton2.Visible = true;

            
        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}