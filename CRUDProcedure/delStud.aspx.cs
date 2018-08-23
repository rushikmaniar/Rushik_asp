using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class delStud : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\Visual Studio 2010\WebSites\Rushik_asp\CRUD\App_Data\Student.mdf;Integrated Security=True;User Instance=True");
        cn.Open();
        if (Request.QueryString["rno"] != null)
        {
            String delqry = "DELETE FROM stud WHERE rno = " + Request.QueryString["rno"];
            SqlCommand cmd = new SqlCommand(delqry, cn);
            int result = cmd.ExecuteNonQuery();
        }
        Response.Redirect("ViewStud.aspx");

    }
}