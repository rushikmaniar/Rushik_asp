using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class ViewStud : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Bca\sem5\ASP\Rushik_asp\CRUD\App_Data\Student.mdf;Integrated Security=True;User Instance=True");
        cn.Open();
        String selqry = "SELECT * FROM stud";
        if (Request.QueryString["s"] != null)
        {
            if (Request.QueryString["s"].ToString().Equals("1"))
            {
                selqry = selqry + " order by rno";

            }
            else if (Request.QueryString["s"].ToString().Equals("2"))
            {
                selqry = selqry + " order by sname";
            }
            else if (Request.QueryString["s"].ToString().Equals("3"))
            {
                selqry = selqry + " order by age";
            }
            else if (Request.QueryString["s"].ToString().Equals("4"))
            {
                selqry = selqry + " order by gender";

            }

        }
        SqlCommand cmd = new SqlCommand(selqry, cn);
        SqlDataReader dr = cmd.ExecuteReader();

        Response.Write("<table border=5 align=center height=250 width=1000>");

        Response.Write("<tr>");
        Response.Write("<th>" + "<a href=ViewStud.aspx?s=1>" + "Rollno" + "</a></th>");
        Response.Write("<th>" + "<a href=ViewStud.aspx?s=2>" + "Name" + "</a></th>");
        Response.Write("<th>" + "<a href=ViewStud.aspx?s=3>" + "Age" + "</a></th>");
        Response.Write("<th>" + "<a href=ViewStud.aspx?s=4>" + "Gender" + "</a></th>");
        Response.Write("<th>Edit</th>");
        Response.Write("<th>Delete</th>");
        Response.Write("</tr>");

        while (dr.Read())
        {

            Response.Write("<tr>");
            Response.Write("<td>" + dr["rno"] + "</td>");
            Response.Write("<td>" + dr["sname"] + "</td>");
            Response.Write("<td>" + dr["age"] + "</td>");
            Response.Write("<td>" + dr["gender"] + "</td>");
            Response.Write("<td>" + "<a href=Studreg.aspx?rno=" + dr["rno"] + ">Edit</a>" + "</td>");
            Response.Write("<td>" + "<a href=delStud.aspx?rno=" + dr["rno"] + ">Delete</a>" + "</td>");
            Response.Write("</tr>");
        }

        Response.Write("<tr><td colspan=6 align=center> <a href=Studreg.aspx> Add Student </a> </td></tr>");
        Response.Write("</table>");


    }
}