using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovanieHW
{
    class Program
    {
        static void Main(string[] args)
        {
            const int allSizeFiles = 565 * 1024;
            const int fileSizeMB = 780;
            double allSize = 0;
            double allTime = 0;
            Random random = new Random();
            int type;
            List<Storage> storages = new List<Storage>();
            do
            {
                Storage st;
                type = random.Next(3);
                if (type == 0)
                {
                    Flash item = new Flash(random.Next().ToString(), random.Next().ToString(), random.Next(10000) + 2000);
                    st = item;
                    allSize += item.memorySizeMB;
                }
                else if (type == 1)
                {
                    HDD item = new HDD(random.Next(14) + 1, random.Next(10000) + 3000, random.Next().ToString(), random.Next().ToString());
                    st = item;
                    allSize += item.memorySizeMB;
                }
                else
                {
                    DVD item = new DVD(true, random.Next().ToString(), random.Next().ToString());
                    st = item;
                    allSize += item.memorySizeMB;
                }
                storages.Add(st);
            } while (allSize > allSizeFiles);
            Console.WriteLine("Общая память всех устройств "+allSize);
            foreach (Storage st in storages)
            {
                allTime += st.CopyFile(fileSizeMB);
            }
            Console.WriteLine($"Нужное время для копирования {allTime} секунд");
            foreach (Storage st in storages)
            {
                st.GetType();
            }
            Console.ReadLine();
        }
    }
}
