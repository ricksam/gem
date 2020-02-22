using Dapper;
using System.Collections.Generic;
using System;
using System.Data;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Http;
using GEM.Helpers;
using GEM.Models;

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
               _conn = new System.Data.SqlClient.SqlConnection(@"Data Source=rcksoftware.cbmmxoygefmo.us-east-2.rds.amazonaws.com;Initial Catalog=gem;Persist Security Info=True;User ID=admin;Password=RCK6px2erjr;Encrypt=True;TrustServerCertificate=True;");
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

       /*****************************************************************/

       public List<PrimaryKey> GetPrimaryKeys()
        {
            List<PrimaryKey> list = new List<PrimaryKey>();
            try
            {
                _conn.Open();
                DataTable dt = ((System.Data.Common.DbConnection)_conn).GetSchema("IndexColumns");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PrimaryKey primaryKey = new PrimaryKey();
                    primaryKey.Table = dt.Rows[i]["TABLE_NAME"].ToString();
                    primaryKey.Column = dt.Rows[i]["COLUMN_NAME"].ToString();
                    if (_conn is System.Data.SqlClient.SqlConnection)
                    {
                        if (dt.Rows[i]["INDEX_NAME"].ToString().StartsWith("PK__"))
                        {
                            list.Add(primaryKey);
                        }
                    }
                    /*else if (_conn is MySql.Data.MySqlClient.MySqlConnection)
                    {
                        if (dt.Rows[i]["INDEX_NAME"].ToString().StartsWith("PRIMARY"))
                        {
                            list.Add(primaryKey);
                        }
                    }*/
                }
            }
            finally
            {
                Dispose();
            }
            return list;
        }

        public List<ForeignKey> GetForeignKeys()
        {
            //DataTable dataTable = null;
            if (_conn is System.Data.SqlClient.SqlConnection)
            {
                return this.Query<ForeignKey>(
                    @" SELECT f.name AS CONSTRAINT_NAME,
                       OBJECT_NAME(f.parent_object_id) AS Table,
                       COL_NAME(fc.parent_object_id, fc.parent_column_id) AS Column,
                       OBJECT_NAME (f.referenced_object_id) AS ReferenceTable,
                       COL_NAME(fc.referenced_object_id, fc.referenced_column_id) AS ReferenceColumn
                     FROM sys.foreign_keys AS f
                     INNER JOIN sys.foreign_key_columns AS fc
                     ON f.OBJECT_ID = fc.constraint_object_id").AsList();
            }
            /*else if (_conn is MySql.Data.MySqlClient.MySqlConnection)
            {
                return this.Query<ForeignKey>(
                  " SELECT " +
                  "   constraint_name," +
                  "   table_name AS Table," +
                  "   column_name AS Column, " +
                  "   referenced_table_name AS ReferenceTable, " +
                  "   referenced_column_name AS ReferenceColumn" +
                  " FROM information_schema.KEY_COLUMN_USAGE" +
                  " where referenced_table_name is not null" +
                  " ORDER BY TABLE_NAME, COLUMN_NAME", "FOREIGNKEYS").AsList();
            }*/
            else {
                return new List<ForeignKey>();
            }
        }
   }
}
