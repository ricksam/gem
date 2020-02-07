using Dapper;
using System.Collections.Generic;
using System;
using System.Data;

namespace GEM.Repository
{
   public class Context : IDisposable
   {
       
       private IDbConnection _conn { get; set; }
       private IDbTransaction _transaction { get; set; } 

       public IEnumerable<T> Query<T>(string sql, object param = null)
       {
           return _conn.Query<T>(sql, param, _transaction);
       }

       public int Execute(string sql, object param = null)
       {
           return _conn.Execute(sql, param, _transaction);
       }
       
       public IDataReader ExecuteReader(string sql, object param = null)
       { 
           return _conn.ExecuteReader(sql, param, _transaction);
       } 

       public Context()
       {
           if (_conn == null)
           {
               //_conn = new MySql.Data.MySqlClient.MySqlConnection("Server=18.229.3.93;Database=gem;Uid=admin;Pwd=RCK6px2erjr;");
               _conn = new System.Data.SqlClient.SqlConnection(@"Data Source=rcksoftware.cbmmxoygefmo.us-east-2.rds.amazonaws.com;Initial Catalog=gem;Persist Security Info=True;User ID=admin;Password=RCK6px2erjr;Encrypt=False;TrustServerCertificate=True; Encrypt=True");
           }
       }
       
       public string PrepareInsert(string sql_insert, string primarykey_field)
       {
           //if (_conn is System.Data.SqlClient.SqlConnection) {
               return string.Format(sql_insert, "OUTPUT Inserted."+ primarykey_field, "");
           //}
           //if (_conn is MySql.Data.MySqlClient.MySqlConnection) {
           //    return string.Format(sql_insert, "", ";SELECT LAST_INSERT_ID()");
           //}
           //sqlite: ";select last_insert_rowid()"
           //return sql_insert;
       }
       
       public void BeginTransaction()
       { 
           _conn.Open(); 
           _transaction = _conn.BeginTransaction();
       } 

       public void Commit() 
       { 
           _transaction.Commit();
       } 

       public void Rollback() 
       { 
           _transaction.Rollback();
       } 

       public void Dispose()
       {
           if (_transaction != null)
           { 
               _transaction.Dispose();
               _transaction = null;
           }  
           
           if (_conn != null)
           {
               if (_conn.State == ConnectionState.Open)
               {
                   _conn.Close();
                   _conn.Dispose();
               }
               _conn = null;
           }
       }

       public static int LocalGMT()
       {
           var info = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
           return info.BaseUtcOffset.Hours;//HttpContext.Current.Request.ClientCertificate.ValidFrom.Subtract(DateTime.UtcNow).Hours;
       }

       public static DateTime GetLocalData(DateTime datetime)
       {
           if (datetime != DateTime.MinValue)
           {
               return datetime.AddHours(LocalGMT());
           }

           return DateTime.MinValue;
       }

       public static DateTime? GetLocalData(DateTime? datetime)
       {
           if (datetime != null)
           {
               return (datetime ?? DateTime.MinValue).AddHours(LocalGMT());
           }

           return null;
       }
   }
}
