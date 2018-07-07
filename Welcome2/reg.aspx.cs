using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            Response.Write("<h2>Hello welcome To Page </h2>");
        }
        else {
            Response.Write("<h2>Welcome " + Request.Form["uname"].ToString() + "</h2>");
        }
        
    }
  
}