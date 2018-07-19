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
        String s = Request.QueryString["s"];
        Response.Write("<h2>Power Of Query String </h2>");
        Response.Write("<h2>You Selected Page : " + s + "</h2>");
    }
}