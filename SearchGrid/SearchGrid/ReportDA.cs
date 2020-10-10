using Microsoft.ApplicationBlocks.Data;
using SearchGrid.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SearchGrid
{
    public class ReportDA
    {
        string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["PracticalTest"].ToString();


        internal DataSet CancellationReport(Report CR)
        {
            SqlConnection con = new SqlConnection(strConn);
            try
            {
                DataSet ds = new DataSet();
                SqlParameter[] commandParameters = new SqlParameter[0];
                //commandParameters[0] = new SqlParameter("@CHSCId", SqlDbType.Int);
                //commandParameters[0].Value = Convert.ToString(CR.CHSCId);



                ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_bindDetails", commandParameters);
                return ds;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}