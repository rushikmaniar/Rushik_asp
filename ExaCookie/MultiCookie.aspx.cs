using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MultiCookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmd_submit_Click(object sender, EventArgs e)
    {
        HttpCookie ck = new HttpCookie("userinfo");
        ck.Values.Add("name", name.Text);
        ck.Values.Add("age", age.Text);
        ck.Values.Add("contact", Contact.Text);

        ck.Expires = DateTime.Now + new TimeSpan(0, 0, 30);
        Response.Cookies.Add(ck);
        Response.Write("cookie Created");
    }
    protected void cmd_cookie_Click(object sender, EventArgs e)
    {
        HttpCookie ck = new HttpCookie("userinfo");
        ck.Values.Add("name", name.Text);
        ck.Values.Add("age", age.Text);
        ck.Values.Add("contact", Contact.Text);

        cookiename.Value = "userinfo";
        
        ck.Expires = DateTime.Now + new TimeSpan(0, 0, 30);
        Response.Cookies.Add(ck);
        Response.Write("cookie Created");
    }
}