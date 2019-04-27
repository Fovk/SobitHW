using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLevelHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSet = new DataSet("ShopDB");

            var tables = new List<DataTable>();
            int tablerdersIndex = 0, tableEmployeesIndex = 1, tableCustomersIndex = 2, tableOrderDetailsIndex = 3, tableProductsIndex = 4;

            tables.Add(new DataTable());

            tables[tablerdersIndex].TableName = "Orders";
            tables[tablerdersIndex].Columns.Add(new DataColumn
            {
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                ColumnName = "Id",
                DataType = typeof(Guid),
                Unique = true
            });



            tables[tablerdersIndex].PrimaryKey = new DataColumn[] { tables[tablerdersIndex].Columns["Id"] };
            tables[tablerdersIndex].Columns.Add("Time", typeof(DateTime));
            tables[tablerdersIndex].Columns.Add("CustomerId", typeof(Guid));
            tables[tablerdersIndex].Columns.Add("EmployeeId", typeof(Guid));


            tables.Add(new DataTable());



            tables.Add(new DataTable());

            tables[tableEmployeesIndex].TableName = "Employees";
            tables[tableEmployeesIndex].Columns.Add(new DataColumn
            {
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                ColumnName = "Id",
                DataType = typeof(Guid),
                Unique = true
            });

            tables[tableEmployeesIndex].PrimaryKey = new DataColumn[] { tables[tableEmployeesIndex].Columns["Id"] };
            tables[tableEmployeesIndex].Columns.Add("Name", typeof(string));
            tables[tableEmployeesIndex].Columns.Add("Salary", typeof(int));

            tables[tableCustomersIndex].TableName = "Customers";
            tables[tableCustomersIndex].Columns.Add(new DataColumn
            {
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                ColumnName = "Id",
                DataType = typeof(Guid),
                Unique = true
            });

            tables[tableCustomersIndex].PrimaryKey = new DataColumn[] { tables[tableCustomersIndex].Columns["Id"] };
            tables[tableCustomersIndex].Columns.Add("Name", typeof(string));



            tables.Add(new DataTable());

            tables[tableOrderDetailsIndex].TableName = "OrderDetails";
            tables[tableOrderDetailsIndex].Columns.Add(new DataColumn
            {
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                ColumnName = "Id",
                DataType = typeof(Guid),
                Unique = true
            });

            tables[tableOrderDetailsIndex].PrimaryKey = new DataColumn[] { tables[tableOrderDetailsIndex].Columns["Id"] };
            tables[tableOrderDetailsIndex].Columns.Add("OrderId", typeof(Guid));
            tables[tableOrderDetailsIndex].Columns.Add("ProductId", typeof(Guid));



            tables.Add(new DataTable());

            tables[4].TableName = "Products";
            tables[4].Columns.Add(new DataColumn
            {
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                ColumnName = "Id",
                DataType = typeof(Guid),
                Unique = true
            });

            tables[tableProductsIndex].PrimaryKey = new DataColumn[] { tables[tableProductsIndex].Columns["Id"] };
            tables[tableProductsIndex].Columns.Add("Name", typeof(string));
            tables[tableProductsIndex].Columns.Add("Cost", typeof(int));


            foreach (var table in tables)
            {
                dataSet.Tables.Add(table);
            }


            dataSet.Relations.Add("Employees_Orders_FK", dataSet.Tables["Employees"].Columns["Id"], dataSet.Tables["Orders"].Columns["EmployeeId"]);
            dataSet.Relations.Add("Customers_Orders_FK", dataSet.Tables["Customers"].Columns["Id"], dataSet.Tables["Orders"].Columns["CustomerId"]);

            dataSet.Relations.Add("Orders_OrderDetails_FK", dataSet.Tables["Orders"].Columns["Id"], dataSet.Tables["OrderDetails"].Columns["OrderId"]);
            dataSet.Relations.Add("Product_OrderDetails_FK", dataSet.Tables["Products"].Columns["Id"], dataSet.Tables["OrderDetails"].Columns["ProductId"]);

        }
    }
}
