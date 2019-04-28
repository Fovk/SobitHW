using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OnlineAdoHW2
{
    public class DBservice
    {
        private readonly string _providerName;
        private SqlConnection sqlConnection;
        private SqlTransaction transaction;
        public SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
        public DBservice()
        {
            stringBuilder.ApplicationName = "OnlineAdoHW2";
            stringBuilder.AttachDBFilename = @"C:\Users\Dell\source\repos\OnlineAdoHW2\OnlineAdoHW2\Database.mdf";
            stringBuilder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            stringBuilder.IntegratedSecurity = false;
        }

        public void AddTable(string connectionstring)
        {
            using (var connection = new SqlConnection())
            using (var command = connection.CreateCommand())
            {
                try
                {
                    connection.ConnectionString = connectionstring;
                    connection.Open();
                    transaction = connection.BeginTransaction();
                    command.CommandText = $"use Database;" +
                        $"go;" +
                        $"create table Gruppa(" +
                        $"id int not null identity(1,1) primary key," +
                        $"Name nvarchar(256) not null";
                    command.Transaction = transaction;

                    transaction.Commit();
                    transaction.Dispose();
                }
                catch (DbException exception)
                {
                    transaction?.Rollback();
                    transaction?.Dispose();
                    throw;
                }
                catch (Exception exception)
                {
                    transaction?.Rollback();
                    transaction?.Dispose();
                    throw;
                }
            }
        }
    }
}
