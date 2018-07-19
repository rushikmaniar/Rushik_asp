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

    }
    protected void createcookiebtn_Click(object sender, EventArgs e)
    {
        HttpCookie ck = new HttpCookie("uname");
        ck.Value = uname.Text;
        ck.Expires = DateTime.Now + new TimeSpan(0, 0, 30);
        Response.Cookies.Add(ck);
        Response.Write("cookie Created");
    }
}