using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class DataDisplay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Text = Session["moviename"].ToString();
        Label5.Text = Session["time"].ToString();
        Label16.Text = Session["city"].ToString();
        Label6.Text = Session["theater"].ToString();
        Label15.Text = Session["Seat"].ToString();
        Label9.Text = Session["seattype"].ToString();
        Label17.Text = Session["date"].ToString();
        Label23.Text = Session["prize"].ToString();


        

        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String a = ConfigurationManager.ConnectionStrings["BookTicket"].ToString();
        SqlConnection con = new SqlConnection(a);
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into BookedTicket" + "(MovieName,Time,Date,Theater,City,Seat,SeatType,Fare)values(@MovieName,@Time,@Date,@Theater,@City,@Seat,@SeatType,@Fare)", con);

        cmd.Parameters.AddWithValue("@MovieName",Label3.Text);
        cmd.Parameters.AddWithValue("@Time", Label5.Text);
        cmd.Parameters.AddWithValue("@Date", Label17.Text);
        cmd.Parameters.AddWithValue("@Theater", Label6.Text);
        cmd.Parameters.AddWithValue("@City", Label16.Text);
        cmd.Parameters.AddWithValue("@Seat", Label15.Text);
        cmd.Parameters.AddWithValue("@SeatType", Label9.Text);
        cmd.Parameters.AddWithValue("@Fare", Label23.Text); 
        cmd.ExecuteNonQuery();
        
        Response.Redirect("Home.aspx");




       
    }
}