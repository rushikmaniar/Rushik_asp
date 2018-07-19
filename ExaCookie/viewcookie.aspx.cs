using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class viewcookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //HttpCookie ck = (HttpCookie)Request.Cookies["uname"];
        HttpCookie ck = (HttpCookie)Request.Cookies[0];
        if (ck != null)
        {
            Response.Write("value : " + ck.Value);
        }
        else {
            Response.Write("Cookie Destroy ");
        }
    }
}