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
        if (ViewState["no1"] != null)
        {
            String opr = ViewState["opr"].ToString();

            int temp = int.Parse(ViewState["no1"].ToString());
            int new_state = int.Parse(ansbox.Text);

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
        //change opr to add
        ViewState["opr"] = "+";
        ansbox.Text = "";
        ansbox.Focus();
    }
    protected void cmdSub_Click(object sender, EventArgs e)
    {
        //check if viewstate is set ot not
        if (ViewState["no1"] != null)
        {
            String opr = ViewState["opr"].ToString();

            int temp = int.Parse(ViewState["no1"].ToString());
            int new_state = int.Parse(ansbox.Text);

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
        //change opr to add
        ViewState["opr"] = "-";
        ansbox.Text = "";
        ansbox.Focus();
    }
    protected void cmdMul_Click(object sender, EventArgs e)
    {
        //check if viewstate is set ot not
        if (ViewState["no1"] != null)
        {
            String opr = ViewState["opr"].ToString();

            int temp = int.Parse(ViewState["no1"].ToString());
            int new_state = int.Parse(ansbox.Text);

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
        //change opr to add
        ViewState["opr"] = "*";
        ansbox.Text = "";
        ansbox.Focus();
    }
    protected void cmdDiv_Click(object sender, EventArgs e)
    {
        //check if viewstate is set ot not
        if (ViewState["no1"] != null)
        {
            String opr = ViewState["opr"].ToString();

            int temp = int.Parse(ViewState["no1"].ToString());
            int new_state = int.Parse(ansbox.Text);

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
            
            String opr = ViewState["no1"].ToString();
            Response.Write("as : " + opr);
            int temp = int.Parse(ViewState["no1"].ToString());
            int new_state = 0;
    
            if(ansbox.Text != null && ansbox.Text != "")
                new_state = int.Parse(ansbox.Text);
            else
                new_state = temp;

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

                }

            }
            ViewState["no1"] = temp;
            outputbox.Text = temp.ToString();
            

        }
        ansbox.Text = "";
        ansbox.Focus();
    }
}