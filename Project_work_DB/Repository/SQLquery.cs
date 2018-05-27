using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_work_DB.Repository
{
    public class SQLquery
    {
        public string Query_TargetPeople { get; set; }
        public string Query_Product { get; set; }
        public string Query_Managers { get; set; }
        public string Query_Promotion { get; set; }
        public string Query_Sales { get; set; }
        public string Query_Market { get; set; }

        public SQLquery()
        {
            Query_TargetPeople = "Select* FROM TARGET_PEOPLE";
            Query_Sales = "Select* from SALES";
            Query_Promotion = "Select* from PROMOTION";
            Query_Product = "Select* from PRODUCT";
            Query_Market = "Select* from MARKET";
            Query_Managers = "Select* from MANAGERS";
        }       
    }
}
