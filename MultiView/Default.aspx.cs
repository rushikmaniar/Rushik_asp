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

    protected void SemDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        String sem = SemDropDownList.SelectedValue;
        Response.Write("<h2>Class : " + sem + "</h2>");
        if (sem.Equals("FY"))
        {
            SubjectDropDownList.Items.Clear();
            SubjectDropDownList.Items.Add("English");
            SubjectDropDownList.Items.Add("C");
            SubjectDropDownList.Items.Add("HTML");
        }
        else if (sem.Equals("SY"))
        {
            SubjectDropDownList.Items.Clear();
            SubjectDropDownList.Items.Add("MATHS");
            SubjectDropDownList.Items.Add("C++");
            SubjectDropDownList.Items.Add("PHP");
        }
        else
        {

            SubjectDropDownList.Items.Clear();
            SubjectDropDownList.Items.Add("ASP.net");
            SubjectDropDownList.Items.Add("J2EE");
            SubjectDropDownList.Items.Add("SEO");
        }
    }

    protected void cmd_1to2All_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ListBox1.Items.Count; i++)
        {
            ListBox2.Items.Add(ListBox1.Items[i].ToString());
        }
        ListBox1.Items.Clear();

    }
    protected void cmd_1to2Sel_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ListBox1.Items.Count; i++)
        {
            if (ListBox1.Items[i].Selected == true)
            {
                ListBox2.Items.Add(ListBox1.Items[i].ToString());
                ListBox1.Items.RemoveAt(i--);
            }
        }

    }
    protected void cmd_2to1Sel_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ListBox2.Items.Count; i++)
        {
            if (ListBox2.Items[i].Selected == true)
            {
                ListBox1.Items.Add(ListBox2.Items[i].ToString());
                ListBox2.Items.RemoveAt(i--);
            }
        }
    }
    protected void cmd_2to1All_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ListBox2.Items.Count; i++)
        {
            ListBox1.Items.Add(ListBox2.Items[i].ToString());
        }
        ListBox2.Items.Clear();
    }
}