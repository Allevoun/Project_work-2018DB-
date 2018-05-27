using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_work_DB.Repository
{
    public static class DBconnection
    {
        //public List<TARGET_PEOPLE> GetUsers()
        //{
        //    List<TARGET_PEOPLE> _users = new List<TARGET_PEOPLE>();

        //    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DBmodel"].ConnectionString))
        //    {
        //        _users = db.Query<TARGET_PEOPLE>("SELECT * FROM TARGET_PEOPLE").ToList();
        //    }
        //    return _users;
        //}
        
        public static string CnnVal()
        {
            return ConfigurationManager.ConnectionStrings["DBmodel"].ConnectionString;
        } 
    }
}
