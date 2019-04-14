using System;
using System.Configuration;
using System.Data.Common;
//using System.Data.SqlClient;

namespace Services
{
    public class DBservice
    {
        private readonly string _connectionstring;
        private readonly string _providerName;
        private readonly DbProviderFactory _dbProviderFactory;
        private DbTransaction transaction;
        public DBservice()
        {
            _connectionstring = ConfigurationManager.ConnectionStrings["testconnectionString"].ConnectionString;
            _providerName = ConfigurationManager.ConnectionStrings["testconnectionString"].ProviderName;
            _dbProviderFactory = DbProviderFactories.GetFactory(_providerName);
        }

        public void AddTable()
        {
            using (var connection = _dbProviderFactory.CreateConnection())
            using (var command = connection.CreateCommand())
            {
                try
                {
                    connection.ConnectionString = _connectionstring;
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

