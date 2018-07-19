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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View1);
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View2);
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View3);
    }
}