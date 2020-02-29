using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConfirmBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["seat"] = TextBox1.Text;
        Session["seattype"] = DropDownList1.Text;    
               
        int c = 1;
        if (DropDownList1.SelectedIndex == 1)
        {
            int a = 400;
            int b = Convert.ToInt32(TextBox1.Text);
            c = a * b; 
        }
        if (DropDownList1.SelectedIndex == 2)
        {
            int a = 300;
            int b = Convert.ToInt32(TextBox1.Text);
             c = a * b;
        }
        if (DropDownList1.SelectedIndex == 3)
        {
            int a = 200;
            int b = Convert.ToInt32(TextBox1.Text);
            c = a * b;
        }
        if (DropDownList1.SelectedIndex == 4)
        {
            int a = 100;
            int b = Convert.ToInt32(TextBox1.Text);
            c = a * b;
        }

        Session["prize"] = (c);
        Response.Redirect("DataDisplay.aspx");


         }
}