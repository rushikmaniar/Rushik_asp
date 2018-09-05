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
    protected void cmdAdd_Click(object sender, EventArgs e)
    {
        //check if viewstate is set ot not

        calculate();
        //change opr to add
        ViewState["opr"] = "+";
        ansbox.Text = "";
        ansbox.Focus();
    }
    protected void cmdSub_Click(object sender, EventArgs e)
    {
        //check if viewstate is set ot not

        calculate();
        //change opr to add
        ViewState["opr"] = "-";
        ansbox.Text = "";
        ansbox.Focus();
    }
    protected void cmdMul_Click(object sender, EventArgs e)
    {
        //check if viewstate is set ot not

        calculate();
        //change opr to add
        ViewState["opr"] = "*";
        ansbox.Text = "";
        ansbox.Focus();
    }
    protected void cmdDiv_Click(object sender, EventArgs e)
    {
        //check if viewstate is set ot not

        calculate();
        //change opr to add
        ViewState["opr"] = "/";
        ansbox.Text = "";
        ansbox.Focus();
    }
    protected void cmdEqual_Click(object sender, EventArgs e)
    {
        if (ViewState["opr"] == null)
        {
            //simple equal
            outputbox.Text = ansbox.Text;
        }
        else
        {

            //equal with operation
            calculate();
          
        }
        ViewState["opr"] = "=";
        ansbox.Text = "";
        ansbox.Focus();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (ViewState["opr"] != null)
        {
            ViewState["opr"] = null;
        }

        if (ViewState["no1"] != null)
        {
            ViewState["no1"] = null;
        }

        ansbox.Text = "";
        outputbox.Text = "";
        Response.Redirect("Default.aspx");
    }
    protected void calculate()
    {
        if (ViewState["no1"] != null)
        {
            String opr = ViewState["opr"].ToString();

            int temp = int.Parse(ViewState["no1"].ToString());
            int new_state = 0;
            if (ansbox.Text != "")
            {
                new_state = int.Parse(ansbox.Text);
            }
            else
            {
                new_state = temp;
            }

            if (opr == "+")
            {
                //add
                temp = temp + new_state;
            }
            else if (opr == "-")
            {
                //sub
                temp = temp - new_state;
            }
            else if (opr == "*")
            {
                //mul
                temp = temp * new_state;
            }
            else if (opr == "/")
            {
                //div
                if (new_state != 0)
                {
                    temp = temp / new_state;
                }
                else
                {
                    //cannot divide by zero
                    Response.Write("<h3 style='color:red'>Cannot Divide By Zero</style></h3>");
                }

            }
            ViewState["no1"] = temp;
            outputbox.Text = temp.ToString();
        }
        else
        {
            //view state not saved

            ViewState["no1"] = ansbox.Text;

        }

    }
}