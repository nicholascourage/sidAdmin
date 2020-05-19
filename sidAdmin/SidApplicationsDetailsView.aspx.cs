using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


namespace sidAdmin
{
    public partial class SidApplicationDetailsView : System.Web.UI.Page
    {

        string connStr = ConfigurationManager.ConnectionStrings["SID2ConnectionString"].ConnectionString;

        SqlDataAdapter sqlda = new SqlDataAdapter();

        SqlCommand com = new SqlCommand();

        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindFormView();

            }
        }

        private void BindFormView()
        {

            var ApplicationID = Request.QueryString["ApplicationID"];

            SqlConnection conn = new SqlConnection(connStr);

            dt = new DataTable();

            com.Connection = conn;

            com.CommandText = "SELECT ApplicationID, ApplicationName, ApplicationDescription, ApplicationLocation FROM Applications WHERE ApplicationID = " + ApplicationID + ""; 

            sqlda = new SqlDataAdapter(com);

            sqlda.Fill(dt);

            FormView1.DataSource = dt;

            FormView1.DataBind();

        }


        protected void FormView1_ItemDeleting( object sender, EventArgs e)
        {
            DataKey key = FormView1.DataKey;

            SqlConnection conn = new SqlConnection(connStr);

            com.Connection = conn;

            com.CommandText = "DELETE FROM Applications WHERE ApplicationID ='" + key.Value.ToString() + "'";

            conn.Open();

            com.ExecuteNonQuery();

            conn.Close();


            BindFormView();

            //Response.Write("<button type=\"button\" class=\"btn btn - primary\" data-toggle=\"modal\" data-target=\"#exampleModalLong\"> Launch Demo Modal </button>");

            Response.Write("<script language='javascript'>window.alert('Application deleted from SidAdmin.');window.location='SidApplications.aspx';</script>");
        }

        protected void FormView1_ItemUpdating(object sender, EventArgs e)
        {

            DataKey key = FormView1.DataKey;

            TextBox ApplicationName = (TextBox)FormView1.FindControl("ApplicationName");

            SqlConnection conn = new SqlConnection(connStr);

            com.Connection = conn;

            com.CommandText = "UPDATE Applications SET ApplicationName ='" + ApplicationName.Text + "' WHERE ApplicationID = '" + key.Value.ToString() + "'";

            conn.Open();

            com.ExecuteNonQuery();

            Response.Write("");

            BindFormView();

            conn.Close();


        }

        protected void FormView1_ModeChanging(object sender, FormViewModeEventArgs e)

        {

            FormView1.ChangeMode(e.NewMode);

            BindFormView();

            if (e.NewMode == FormViewMode.Edit)

            {

                FormView1.AllowPaging = false;

            }

            else

            {

               FormView1.AllowPaging = true;

            }

        }
    }
}