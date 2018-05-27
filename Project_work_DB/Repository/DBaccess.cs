using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_work_DB.Repository
{
    public class DBaccess
    {

        public List<T> GetDBInfo<T>(string sql)
        {
            List<T> _dbIndo = new List<T>();

            using (IDbConnection dbcon = new System.Data.SqlClient.SqlConnection(DBconnection.CnnVal()))
            {
                dbcon.Open();
                _dbIndo = dbcon.Query<T>(sql).ToList();
                dbcon.Close();
            }

            return _dbIndo;
        }
    }
}
