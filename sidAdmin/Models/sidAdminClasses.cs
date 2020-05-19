using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sidAdmin.Models;

namespace sidAdmin
{
    /*public class sidApplicationsStaffMembers
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        //public string appname { get; set; }
        //public string accessTypeDescription { get; set; }

    }*/

    public class getSidApplicationDetailsStaff
    {
        public int ApplicationID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string accessTypeDescription { get; set; }

    }

    public class getSidApplications
    {

        public string applicationsName { get; set; }
        public string applicationDescription { get; set; }
        //public Int32 applicationStaffAccessNo { get; set; }
        public string applicationLocation { get; set; }
        public Int32 applicationId { get; set; }


    }
}