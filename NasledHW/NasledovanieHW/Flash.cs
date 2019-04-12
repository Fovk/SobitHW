using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovanieHW
{
    public class Flash : Storage
    {
        public const int SpeedUSB3 =600;
        public double memorySizeMB;
        public double seizedMemoryMB;
        public double freeMemoryMB;
        public Flash(string name,string model,int memoryMB)
        {
            Name = name;
            Model = model;
            memorySizeMB = memoryMB;
            freeMemoryMB = memoryMB;
            seizedMemoryMB = 0;
        }
        public override double CopyFile(int fileSize)
        {
            if (freeMemoryMB >= fileSize)
            {
                seizedMemoryMB += fileSize;
                freeMemoryMB -= fileSize;
                return fileSize / SpeedUSB3;
            }
            else return 0;
        }

        public override double FreeMemory()
        {
            return freeMemoryMB;
        }

        public override void FullInfo()
        {
            Console.WriteLine($"{Name}{Model}{memorySizeMB}{freeMemoryMB}{seizedMemoryMB}");
        }

        public override double GetMemory()
        {
            return memorySizeMB;
        }
    }
}
