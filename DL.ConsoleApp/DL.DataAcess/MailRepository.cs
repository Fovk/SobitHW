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
	public class MailRepository : IRepository<Mail>
	{
		private DbConnection _connection;

		public MailRepository()
		{
			var connectionString = ConfigurationManager
				.ConnectionStrings["appConnection"]
				.ConnectionString;

			_connection = new SqlConnection(connectionString);
		}

		public void Add(Mail item)
		{
			var sqlQuery = "insert into Mails (Id, CreationDate, DeletedDate, Theme, Text,ReceiverId)" +
                "values (@Id, @CreationDate, @DeletedDate, @Theme, @Text, @ReceiverId)";
			var result = _connection.Execute(sqlQuery, item); // item -> @Id, @CreationDate...
			if (result < 1) throw new Exception("Запись не вставлена");
		}

		public void Delete(Guid Id)
		{
            var sqlQuery = "delete from Mails values where Id=@Id";
            var result = _connection.Execute(sqlQuery, Id);
            if (result < 1) throw new Exception("Запись не вставлена");
        }

		public void Dispose()
		{
			_connection.Close();
		}

		public ICollection<Mail> GetAll()
		{
			var sqlQuery = "select * from Mails";
			return _connection.Query<Mail>(sqlQuery).AsList();
		}

		public void Update(Mail item)
		{
            var sqlQuery = "update CreationDate=@CreationDate, DeletedDate=@DeletedDate, Theme=@Theme, Text=@Text from Receivers where Id=@Id";
            var result = _connection.Execute(sqlQuery, item);
            if (result < 1) throw new Exception("Запись не вставлена");
        }
	}
}
