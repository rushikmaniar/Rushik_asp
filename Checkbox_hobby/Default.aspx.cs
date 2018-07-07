using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String request_data = Request.Form["MCA"];
        Response.Write(request_data);
        for (int i = 0; i < Request.Form.Count; i++)
        {
            Response.Write("<br>"+ "[ " + Request.Form.Keys[i] + " ] " + " => " + Request.Form[i].ToString());
        }
    }
}