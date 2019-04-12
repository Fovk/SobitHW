using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovanieHW
{
 enum DiscType{
        oneside,
        bothside
        }
    public class DVD : Storage
    {
        DiscType discType;
        public const int SpeedReadWrite = 21;
        public double memorySizeMB;
        public double seizedMemoryMB;
        public double freeMemoryMB;
        public DVD(bool isoneside, string name, string model)
        {
           if (isoneside == true)
            {
                discType = DiscType.oneside;
                memorySizeMB = 4.7 * 1024;
                Name = name;
                Model = model;
                seizedMemoryMB = 0;
                freeMemoryMB = memorySizeMB;
            }
                else
            {
                discType = DiscType.bothside;
                memorySizeMB = 9 * 1024;
                Name = name;
                Model = model;
                seizedMemoryMB = 0;
                freeMemoryMB = memorySizeMB;
            }
        }
        public override double CopyFile(int fileSize)
        {
            if (freeMemoryMB >= fileSize)
            {
                seizedMemoryMB += fileSize;
                freeMemoryMB -= fileSize;
                return fileSize / SpeedReadWrite;
            }
            else return 0;
        }

        public override double FreeMemory()
        {
            return freeMemoryMB;
        }

        public override void FullInfo()
        {
            Console.WriteLine($"{Name}{Model}{discType}{memorySizeMB}{freeMemoryMB}{seizedMemoryMB}");
        }

        public override double GetMemory()
        {
            return memorySizeMB;
        }
    }
}
