using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["btn_add"] != null)
        {
            int a = Int16.Parse(Request.Form["txt1"].ToString());
            int b = Int16.Parse(Request.Form["txt2"].ToString());
            int c = a + b;
            Response.Write("<h2>Addition:" + c.ToString() + "</h2>");
        }
        else if (Request.Form["btn_sub"] != null)
        {
            int a = Int16.Parse(Request.Form["txt1"].ToString());
            int b = Int16.Parse(Request.Form["txt2"].ToString());
            int c = a - b;
            Response.Write("<h2>Subtraction:" + c.ToString() + "</h2>");
        }
        else if (Request.Form["btn_mul"] != null)
        {
            int a = Int16.Parse(Request.Form["txt1"].ToString());
            int b = Int16.Parse(Request.Form["txt2"].ToString());
            int c = a * b;
            Response.Write("<h2>Multiplication:" + c.ToString() + "</h2>");
        }
        else if (Request.Form["btn_div"] != null)
        {
            int a = Int16.Parse(Request.Form["txt1"].ToString());
            int b = Int16.Parse(Request.Form["txt2"].ToString());
            if (b == 0){
                Response.Write("<h2>division not possible");
            }
          
            else
            {
                int c = a / b;
                Response.Write("<h2>division:" + c.ToString() + "</h2>");
            }
            
        }
    }
}