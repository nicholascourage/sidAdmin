using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace sidAdmin
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Label1.Text = countSidApplicationsStaff();
                Label2.Text = countSidApplications();

            }
        }

        public string countSidApplicationsStaff()
        {
            //string Literal1 = "";

            using (SqlConnection conn = new SqlConnection())
            {

                string Literal1 = "";

                conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SID2ConnectionString"].ConnectionString;

                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = "SELECT CAST(count(*) AS VARCHAR) AS 'countSidAppsStaff' FROM [SID2].[dbo].[Access] LEFT JOIN Vw_Baxter_CurrentStaff ON Access.StaffID = Vw_Baxter_CurrentStaff.StaffID LEFT JOIN Applications ON Access.ApplicationID = Applications.ApplicationID  LEFT JOIN AccessTypes ON Access.AccessTypeID = AccessTypes.AccessTypeID WHERE Access.DeletedDate IS NULL AND Vw_Baxter_CurrentStaff.StaffID IS NOT NULL";

                    cmd.Connection = conn;

                    conn.Open();

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {

                        while (sdr.Read())
                        {

                           Literal1 = (string)sdr["countSidAppsStaff"];
                        }

                    }

                    conn.Close();

                }

                return Literal1;

   
            }
        }

        public string countSidApplications() {

            using (SqlConnection conn = new SqlConnection()) {

                string Literal2 = "";

                conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SID2ConnectionString"].ConnectionString;

                using (SqlCommand cmd = new SqlCommand()) {

                    cmd.CommandText = "SELECT CAST(COUNT(*) AS VARCHAR) AS 'countSidApplications' FROM SID2.dbo.Applications";

                    cmd.Connection = conn;

                    conn.Open();

                    using (SqlDataReader sdr = cmd.ExecuteReader()) {

                        while (sdr.Read()) {

                            Literal2 = ( string )sdr["countSidApplications"];
                        }
                    }

                    conn.Close();

                }

                return Literal2;

            }
        }

    }
}