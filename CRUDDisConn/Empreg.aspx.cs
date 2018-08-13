using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empreg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["error"] != null)
        {
            Response.Write("<h1 style='color:red' align=center>" + Request.QueryString["error"] + "</h1>");
        }
        SqlConnection cn;
        cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\Visual Studio 2010\WebSites\Rushik_asp\CRUDDisConn\App_Data\Employee.mdf;Integrated Security=True;User Instance=True");

        //Fetch Designation
        String selqry;
        selqry = "SELECT * FROM designation";
        SqlDataAdapter da = new SqlDataAdapter(selqry, cn);
        DataTable dt = new DataTable();
        da.Fill(dt);

        //add to designlist
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                design.Items.Add(dt.Rows[i][j].ToString());
            }

        }

        if (Request.QueryString["edit"] != null)
        {
            selqry = "";

            //edit
            //Update Or Edit
           
            selqry = "SELECT * FROM emp WHERE empno=" + Request.QueryString["edit"];
            SqlDataAdapter empda = new SqlDataAdapter(selqry, cn);
            DataTable empdt = new DataTable();
            empda.Fill(empdt);

            //set values
            empno.Text = empdt.Rows[0][0].ToString();
            empname.Text = empdt.Rows[0][1].ToString();
            
            if (empdt.Rows[0]["gender"].ToString().Equals("Male"))
            {
                Male.Checked = true;
            }
            else {
                Female.Checked = true;
            }
            design.SelectedValue = empdt.Rows[0][3].ToString();
            operation.Value = "edit";
            updateID.Value = empdt.Rows[0][0].ToString();
        }
        else
        {

        }
    }
}