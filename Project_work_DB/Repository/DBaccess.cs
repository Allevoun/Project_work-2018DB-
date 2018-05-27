using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_work_DB.Repository
{
    class DBaccess
    {
        public List<T> GetUsers<T>()
        {
            List<T> _users = new List<T>();

            using (IDbConnection dbcon = new SqlConnection(DBconnection.CnnVal())
            {
                _users = dbcon.Query<T>().ToList();
        }
            return _users;
        }
}

public List<MyClassX> GetDBInfo<MyClassX>(string sql)
{
    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DBmodel"].ConnectionString))
    {
        db.Open();

        var lookup = db.Query<MyClassX, MyClassY, MyClassX>(sql, (_par_one, _par_two) =>
        {
                // не уверен, что должен делать этот код, но скорее всего вам                
                // придется добавить ограничение на T - 
                // т.к. ожидается наличие свойства MyClass
                _par_one.MyClassY = _par_two;
            return _par_one;
        },
        splitOn: splitOn).AsQueryable();

        return lookup.ToList();
        // coll = result; <-- это меняет локальную ссылку на список
        // а не возвращает список наружу.
        // используйте return, чтобы вернуть объект
    }
}
}
}
