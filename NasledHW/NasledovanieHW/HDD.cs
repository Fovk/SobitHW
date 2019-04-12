using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovanieHW
{
    public class HDD : Storage
    {
        public const int SpeedUSB2 = 60;
        int numberSections;
        double[] sections;
        public double memorySizeMB;
        public double seizedMemoryMB;
        public double freeMemoryMB;
        int FirstFreeSection = 0;
        public HDD(int numberOfSections, double section,string name, string model)
        {
            numberSections = numberOfSections;
            sections = new double[numberSections];
            for(int i = 0; i < numberOfSections; i++)
            {
                sections[i] = section;
                memorySizeMB += sections[i];
                freeMemoryMB = memorySizeMB;
                seizedMemoryMB = 0;
            }
            Name = name;
            Model = model;
        }
        public override double CopyFile(int fileSize)
        {
            if (freeMemoryMB >= fileSize)
            {
                do
                {
                    seizedMemoryMB += sections[FirstFreeSection];
                    FirstFreeSection++;
                } while (seizedMemoryMB < fileSize);
                freeMemoryMB -= seizedMemoryMB;
                return fileSize / SpeedUSB2;
            }
            else return 0;
        }

        public override double FreeMemory()
        {
            return freeMemoryMB;
        }

        public override void FullInfo()
        {
            Console.WriteLine($"{Name}{Model}{numberSections}{sections[0]}{memorySizeMB}{freeMemoryMB}{seizedMemoryMB}");
        }

        public override double GetMemory()
        {
            return memorySizeMB;
        }
    }
}
