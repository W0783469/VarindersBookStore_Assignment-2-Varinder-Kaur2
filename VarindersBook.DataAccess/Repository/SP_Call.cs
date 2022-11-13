using System;
using System.Collections.Generic;
using System.Text;
using VarindersBook.DataAccess.Repository.IRepository;
using VarindersBook.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Dapper;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Data.SqlClient;

namespace VarindersBook.DataAccess.Repository
{
    public class SP_Call : ISP_Call
    {
        private readonly ApplicationDbContext _db;
        private static string Connectionstring = "";
        public SP_Call(ApplicationDbContext db)
        {

            _db = db;

            Connectionstring = db.Database.GetDbConnection().ConnectionString;
        }

        public T Single<T>(string procedurename, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(Connectionstring))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.ExecuteScalar<T>(procedurename, param, commandType: System.Data.CommandType.StoredProcedure), typeof(T));
            }
        }

        public void Execute(string procedurename, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(Connectionstring))
            {
                sqlCon.Open();
                sqlCon.Execute(procedurename,param,commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public T OneRecord<T>(string procedurename, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(Connectionstring))
            {
                sqlCon.Open();
                var value = sqlCon.Query<T>(procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
            
            return(T)Convert.ChangeType(value.FirstOrDefault(),typeof(T));
            }
        }

        public IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null)
        {
             
            using (SqlConnection sqlCon = new SqlConnection(Connectionstring))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
                    }
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(Connectionstring))
            {
                sqlCon.Open();
                var result = SqlMapper.QueryMultiple(sqlCon, procedurename, param, commandType: System.Data.CommandType.StoredProcedure);

                var item1 = result.Read<T1>().ToList();
                var item2 = result.Read<T2>().ToList();
                if(item1 !=null && item2 != null)
                {

                    return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(item1, item2);
                }
                return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(new List<T1>(), new List<T2>());

            }

        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
