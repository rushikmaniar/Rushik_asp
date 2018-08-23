using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"] != null)
        {
            Response.Write("<h1>Welcome " + Session["uname"] + "</h1>");
            int temp = int.Parse(Session["count"].ToString());
            temp++;
            Response.Write("<h3>Site Visits :" + temp + "</h3>");
            Session["count"] = temp;
        }
        else if (Request.Form["uname"] != null)
        {
            //signup
            Session["uname"] = Request.Form["uname"];
            Session["count"] = 0;
            Response.Redirect("Login.aspx");
        }
        else {
            Response.Redirect("Default.aspx");
        }
    }
    protected void cmd_logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}