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
    public partial class SidApplicationsStaffDetailsView : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["SID2ConnectionString"].ConnectionString;

        SqlDataAdapter sqlda = new SqlDataAdapter();

        SqlCommand com = new SqlCommand();

        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ( !IsPostBack )
            {
                BindFormView();
                BindStaffAssociatedApplicationsFormView();
            }
        }

        private void BindFormView()
        {
            var StaffID = Request.QueryString["StaffID"];

            SqlConnection conn = new SqlConnection( connStr );

            dt = new DataTable();

            com.Connection = conn;

            com.CommandText = "SELECT Vw_Baxter_CurrentStaff.StaffID, Vw_Baxter_CurrentStaff.Title, Vw_Baxter_CurrentStaff.FirstName, Vw_Baxter_CurrentStaff.LastName, Vw_Baxter_CurrentStaff.email, Vw_Baxter_CurrentStaff.TelephoneWork FROM Vw_Baxter_CurrentStaff WHERE StaffID = " + StaffID + "";

            sqlda = new SqlDataAdapter(com);

            sqlda.Fill(dt);

            SidApplicationsStaffDetailsFormView.DataSource = dt;

            SidApplicationsStaffDetailsFormView.DataBind();
        }

        protected void SidApplicationsStaffDetailsFormView_ItemDeleting(object sender, EventArgs e)
        {
            DataKey key = SidApplicationsStaffDetailsFormView.DataKey;

            SqlConnection conn = new SqlConnection(connStr);

            com.Connection = conn;

            com.CommandText = "DELETE FROM Access WHERE StaffID ='" + key.Value.ToString() + "'";

            conn.Open();

            com.ExecuteNonQuery();

            conn.Close();


            BindFormView();

            //Response.Write("<button type=\"button\" class=\"btn btn - primary\" data-toggle=\"modal\" data-target=\"#exampleModalLong\"> Launch Demo Modal </button>");

            Response.Write("<script language='javascript'>window.alert('Staff Member has been deleted from SidAdmin.');window.location='SidApplicationsStaff.aspx';</script>");
        }

        private void BindStaffAssociatedApplicationsFormView()
        {
            var StaffID = Request.QueryString["StaffID"];

            SqlConnection conn = new SqlConnection(connStr);

            dt = new DataTable();

            com.Connection = conn;

            com.CommandText = "SELECT Vw_Baxter_CurrentStaff.StaffID, Vw_Baxter_CurrentStaff.Title, Vw_Baxter_CurrentStaff.FirstName, Vw_Baxter_CurrentStaff.LastName, Vw_Baxter_CurrentStaff.email, Vw_Baxter_CurrentStaff.TelephoneWork FROM Vw_Baxter_CurrentStaff WHERE StaffID = " + StaffID + "";

            sqlda = new SqlDataAdapter(com);

            sqlda.Fill(dt);

            SidApplicationsStaffDetailsFormView.DataSource = dt;

            SidApplicationsStaffDetailsFormView.DataBind();
        }
    }
}