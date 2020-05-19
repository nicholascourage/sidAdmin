using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace sidAdmin
{
    public partial class SidApplications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                Bind();
            }

        }

        public void Bind()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SID2ConnectionString"].ConnectionString);

            SqlCommand cmd = new SqlCommand("SELECT ApplicationID, ApplicationName, ApplicationDescription, ApplicationLocation FROM Applications", con);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];

                GridView1.DataBind();

                GridView1.UseAccessibleHeader = true;

                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader ;
            }

        }
    }
}