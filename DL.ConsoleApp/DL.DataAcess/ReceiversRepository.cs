using DL.DataAccess.Abstract;
using DL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
//добавим ссылку System.Configuration
using Dapper;//nuget Dapper

namespace DL.DataAcess
{
	public class ReceiversRepository : IRepository<Receiver>
	{
		private DbConnection _connection;

		public ReceiversRepository()
		{
			var connectionString = ConfigurationManager
				.ConnectionStrings["appConnection"]
				.ConnectionString;

			_connection = new SqlConnection(connectionString);
		}

		public void Add(Receiver item)
		{
			var sqlQuery = "insert into Receivers (Id, CreationDate, DeletedDate, FullName, Address)" +
				"values (@Id, @CreationDate, @DeletedDate, @FullName, @Address)";
			var result = _connection.Execute(sqlQuery, item); // item -> @Id, @CreationDate...
			if (result < 1) throw new Exception("Запись не вставлена");
		}

		public void Delete(Guid Id)
		{
            var sqlQuery = "delete from Receivers values where Id=@Id";
            var result = _connection.Execute(sqlQuery, Id);
            if (result < 1) throw new Exception("Запись не вставлена");
        }

		public void Dispose()
		{
			_connection.Close();
		}

		public ICollection<Receiver> GetAll()
		{
			var sqlQuery = "select * from Receivers";
			return _connection.Query<Receiver>(sqlQuery).AsList();
		}

		public void Update(Receiver item)
		{
            var sqlQuery = "update CreationDate=@CreationDate, DeletedDate=@DeletedDate, FullName=@FullName, Address=@Address from Receivers where Id=@Id";
            var result = _connection.Execute(sqlQuery, item); 
            if (result < 1) throw new Exception("Запись не вставлена");
        }

	}
}
