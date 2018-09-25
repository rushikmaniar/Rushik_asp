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
        int cnt = int.Parse(Application["count"].ToString());
        cnt = cnt + 1;
        Response.Write("Total Value is :- "+cnt);
        Application["count"]=cnt;
    }
}