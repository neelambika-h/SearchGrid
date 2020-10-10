using SearchGrid.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchGrid.Controllers
{
    public class ReportController : Controller
    {
        //
        // GET: /Report/
        ReportDA objRDA = new ReportDA();
        public ActionResult Report(int? pageNumber,Report CR)
        {

            DataSet ds = new DataSet();
            try
            {
                
                
                ds = objRDA.CancellationReport(CR);
                if (ds.Tables[0].Rows.Count > 0)
                {

                    List<Report> listDetails = new List<Report>();

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        listDetails.Add(new Report
                        {
                            CandidateId = Convert.ToInt32(dr["CandidateId"]),
                            FirstName = Convert.ToString(dr["FirstName"]),
                            LastName = Convert.ToString(dr["LastName"]),
                            Email = Convert.ToString(dr["Email"]),
                            MobileNo = Convert.ToString(dr["MobileNo"]),
                            City = Convert.ToString(dr["City"]),
                            State = Convert.ToString(dr["State"]),
                            Country = Convert.ToString(dr["Country"]),

                        });
                    }
                    CR.listDetails = listDetails;
                    ViewBag.ReportParam = listDetails;
                    
                }

                //Session["Listdetails"] = listDetails;
                return View(CR);

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
