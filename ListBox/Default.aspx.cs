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