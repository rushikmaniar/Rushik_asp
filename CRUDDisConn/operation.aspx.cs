using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class operation : System.Web.UI.Page
{
    SqlConnection cn;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\Visual Studio 2010\WebSites\Rushik_asp\CRUDDisConn\App_Data\Employee.mdf;Integrated Security=True;User Instance=True");

        if (Request.QueryString["del"] != null)
        {
            //Delete
            //Update Or Edit
            String selqry = "DELETE FROM emp WHERE empno=" + Request.QueryString["del"];
            SqlDataAdapter da = new SqlDataAdapter(selqry, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            Response.Redirect("Viewemp.aspx");
        }
        else if (Request.Form["operation"] != null && Request.Form["operation"] == "edit")
        {
            //Edit record
           
            int empno = Int16.Parse(Request.Form["empno"].ToString());
            int updateid = Int16.Parse(Request.Form["updateid"].ToString());
            String ename = Request.Form["empname"].ToString();
            String gender = Request.Form["Gender"].ToString();
            String desig = Request.Form["design"].ToString();

            

            //check for duplication
            String selqry = "SELECT * FROM emp WHERE empno=" + empno + " AND empno!="+updateid;
            SqlDataAdapter da = new SqlDataAdapter(selqry, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                Response.Redirect("empreg.aspx?error=Record_Already_Exists");
            else { 
            //fire insert query
                String insqry = "UPDATE  emp SET empno="+empno+", ename='"+ename+"', gender='"+gender+"', desig='"+desig+"' WHERE empno="+updateid;
                Response.Write(insqry);
                 da = new SqlDataAdapter(insqry, cn);
                 dt = new DataTable();
                da.Fill(dt);
                da.Update(dt);
                Response.Redirect("Viewemp.aspx");
            }
            
        }

        
        
        else
        {
            //Add record
           
            int empno = Int16.Parse(Request.Form["empno"].ToString());
            String ename = Request.Form["empname"].ToString();
            String gender = Request.Form["Gender"].ToString();
            String desig = Request.Form["design"].ToString();

            

            //check for duplication
            String selqry = "SELECT * FROM emp WHERE empno=" + empno;
            SqlDataAdapter da = new SqlDataAdapter(selqry, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                Response.Redirect("empreg.aspx?error=Record_Already_Exists");
            else { 
            //fire insert query
                String insqry = "INSERT INTO emp VALUES("+empno+",'"+ename+"','"+gender+"','"+desig+"')";
                Response.Write(insqry);
                 da = new SqlDataAdapter(insqry, cn);
                 dt = new DataTable();
                da.Fill(dt);
                da.Update(dt);
                Response.Redirect("Viewemp.aspx");
            }
            
        }
        
        
    }
}