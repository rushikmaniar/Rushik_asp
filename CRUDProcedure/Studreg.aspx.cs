using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Studreg : System.Web.UI.Page
{
    public SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\Visual Studio 2010\WebSites\Rushik_asp\CRUDProcedure\App_Data\Student.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();
        if (Request.QueryString["rno"] != null && IsPostBack == false)
        {

            String selqry = "SELECT * FROM stud WHERE rno=" + Request.QueryString["rno"];

            cmd = new SqlCommand(selqry, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            Rollno.Text = dr["rno"].ToString();
            Name.Text = dr["sname"].ToString();
            Age.Text = dr["age"].ToString();

            if (dr["gender"].ToString().Equals("Male"))
            {
                Male.Checked = true;
            }
            else
            {
                Female.Checked = true;
            }
        }
    }
    protected void cmd_submit_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["rno"] != null)
        {
            //update
            int rno = int.Parse(Request.QueryString["rno"]);

            if (rno == int.Parse(Rollno.Text))
            {
                //no need to check duplication

            }
            else
            {
                //duplication check logic
                String selqry = "SELECT * FROM stud WHERE rno =" + int.Parse(Rollno.Text);
                cmd = new SqlCommand(selqry, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //record already exists
                    Response.Write("Rollno Already Exists");
                    return;
                }

            }
            cn.Close();
            cn.Open();
            //record does not exists go to update
            String updateqry = "UPDATE stud SET rno=" + int.Parse(Rollno.Text) + " ,";
            updateqry += "sname = '" + Name.Text + "' , ";
            updateqry += "Age =" + int.Parse(Age.Text) + " ,";
            if (Male.Checked == true)
            {
                updateqry += "gender = 'Male'";
            }
            else
            {
                updateqry += "gender = 'Female'";
            }
            updateqry += " WHERE rno = " + rno;
            
            cmd = new SqlCommand(updateqry, cn);
            int res = cmd.ExecuteNonQuery();

        }
        else
        {
            //insert
            //duplication check logic
            String selqry = "SELECT * FROM stud WHERE rno =" + int.Parse(Rollno.Text);
            cmd = new SqlCommand(selqry, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //record already exists
                Response.Write("Rollno Already Exists");
                return;
            }
            cn.Close();
            cn.Open();
            //record does not exists go to insert
            String insertqry = "INSERT INTO stud VALUES (" + int.Parse(Rollno.Text) + ",'" + Name.Text + "' , " + int.Parse(Age.Text) + ",";
            if (Male.Checked == true)
            {
                insertqry += "'Male'";
            }
            else
            {
                insertqry += "'Female'";
            }
            insertqry += " )";

            cmd = new SqlCommand("addStud", cn);

            int res = cmd.ExecuteNonQuery();

        }

        Response.Redirect("Viewstud.aspx");
    }
}