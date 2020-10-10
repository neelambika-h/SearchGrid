using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchGrid.Models
{
    public class Report
    {
        public int CandidateId { get; set; }

        public string FirstName { get; set; }

        public string FarmerName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string MobileNo { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }



        


        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public int TotalCount { get; set; }

        public List<Report> listDetails { get; set; }

        public int PagerCount { get; set; }

        public int Id { get; set; }

        public int PageSizeValue { get; set; }

        public int ddlPageSize { get; set; }
    }
}