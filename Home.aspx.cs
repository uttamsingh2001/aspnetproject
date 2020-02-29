using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
   
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["wel"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {

            Session["moviename"] = " Gold ";
            Response.Redirect("Book.aspx");
        }
                
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["wel"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {

            Session["moviename"] = " Student of year 2 ";
            Response.Redirect("Book.aspx");
        }
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["wel"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            Session["moviename"] = " war ";
            Response.Redirect("Book.aspx");
        }
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["wel"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            Session["moviename"] = "  The Maze Runner";
            Response.Redirect("Book.aspx");
        }
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["wel"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            Session["moviename"] = " Dicision ";
            Response.Redirect("Book.aspx");
        }
    }

    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["wel"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            Session["moviename"] = " NoteBook ";
            Response.Redirect("Book.aspx");
        }
    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["wel"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            Session["moviename"] = " Junglee ";
            Response.Redirect("Book.aspx");
        }
    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["wel"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            Session["moviename"] = " bhoomi ";
            Response.Redirect("Book.aspx");
        }
    }
    
}