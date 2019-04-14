using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBD1HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var tableGruppa = new DBservice();
            tableGruppa.AddTable();
        }
    }
}
