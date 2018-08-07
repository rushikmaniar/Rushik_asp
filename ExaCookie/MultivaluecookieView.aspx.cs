using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MultivaluecookieView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //HttpCookie ck = (HttpCookie)Request.Cookies["uname"];
        HttpCookie ck = (HttpCookie)Request.Cookies[Request.Form["cookiename"]];
        Response.Write("<h2>View cookie</h2>");
        if (ck != null)
        {
            foreach(String row in ck.Values){
                Response.Write("<br><h3>" + row + " : " + ck.Values[row] + "</h3>");
            }
            
        }
        else
        {
            Response.Write("Cookie Destroy ");
        }
    }
}