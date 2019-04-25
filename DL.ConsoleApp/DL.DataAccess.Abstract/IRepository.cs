using DL.Models;
using System;
using System.Collections.Generic;

namespace DL.DataAccess.Abstract
{
	public interface IRepository<T> : IDisposable where T: Entity //IDisposable для оборачивания using(){}
	{
		void Add(T item);
		void Update(T item);
		void Delete(Guid Id);
		ICollection<T> GetAll();
	}
}