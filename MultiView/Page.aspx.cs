using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["s"] != null)
        {
            String s = Request.QueryString["s"];
            Response.Write("<h2>Power Of Query String </h2>");
            Response.Write("<h2>You Selected Page : " + s + "</h2>");

        }
        if (Request.QueryString["class"] != null)
        {
            Response.Write("<h3>");
            if (Request.QueryString["class"].Equals("FYBCA"))
            {
                Response.Write("<h2>Subjects : <br>");
                Response.Write("English<br>");
                Response.Write("HTML<br>");
                Response.Write("C<br>");
            }

            else if (Request.QueryString["class"].Equals("SYBCA"))
            {
                Response.Write("Subjects : <br>");
                Response.Write("MATHS<br>");
                Response.Write("C++<br>");
                Response.Write("PHP<br>");
            }
            else
            {
                Response.Write("<br>Subjects : ");
                Response.Write("<br>SEO");
                Response.Write("<br>ASP.NET");
                Response.Write("<br>J2EE");

            }
            Response.Write("</h3>");
        }
    }
}