using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Stud : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        String output = "";
        output += "<br><h2>Student Details</h2>";
        output += "<br>Student No :" + Request.Form["StudNo"];
        output += "<br>Student Name :" + Request.Form["StudName"];
        output += "<br>Year :" + Request.Form["Year"];
        output += "<br>Age :" + Request.Form["age"];
        output += "<br>Email :" + Request.Form["email"];
        output += "<br>Contact :" + Request.Form["contact"];
        String hobbies = Request.Form["hobbies$0"] + "  " + Request.Form["hobbies$1"] + "  " + Request.Form["hobbies$2"];
        output += "<br>Hobbies :" + hobbies;
        Response.Write(output);
        
      
    }
}