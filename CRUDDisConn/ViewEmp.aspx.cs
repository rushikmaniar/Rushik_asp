using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewEmp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\Visual Studio 2010\WebSites\Rushik_asp\CRUDDisConn\App_Data\Employee.mdf;Integrated Security=True;User Instance=True");
        String selqry = "SELECT * FROM emp";
        SqlDataAdapter da = new SqlDataAdapter(selqry, cn);
        DataTable dt = new DataTable();
        da.Fill(dt);

        String output = "";
        output += "<table border=10 align=center cellspacing=10 cellpadding=10>";
        output += "<caption><h1>Employee Data</h1></caption>";
        //rows
        output += "<tr>";
        
        //Columns Heading
        for (int i = 0; i < dt.Columns.Count; i++)
        {
            output += "<th>"+dt.Columns[i]+"</th>";
        }
        output += "<th>Edit</th>";
        output += "<th>Delete</th>";
        output += "</tr>";

        //Printing Data
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            output += "<tr>";
            //cols
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                output += "<td>" + dt.Rows[i][j] + "</td>";
            }
            output += "<td><a href='Empreg.aspx?edit=" + dt.Rows[i][0] + "'><button>Edit</button></a></td>";
            output += "<td><a href='operation.aspx?del=" + dt.Rows[i][0] + "'><button>Delete</button></a></td>";
            output += "</tr>";
        }
        output += "</table>";
        output += "<br><a href='Empreg.aspx'><h2 align=center><ul>+ Add Employee</h2><a>";

        Response.Write(output);
    }
}