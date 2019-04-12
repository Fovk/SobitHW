using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovanieHW
{
    public abstract class Storage
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public abstract double GetMemory();
        public abstract double CopyFile(int fileSize);
        public abstract double FreeMemory();
        public abstract void FullInfo();
    }
}
