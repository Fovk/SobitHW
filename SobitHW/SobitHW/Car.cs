using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobitHW
{
    public delegate void ReporterPostionDelegate(string text);
    public abstract class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public ReporterPostionDelegate reporterDelegate;

        public abstract int Move(int x, int y);
        public void RegisterReporter(ReporterPostionDelegate reporter)
        {
            reporterDelegate += reporter;
        }
        public void UnRegisterReporter(ReporterPostionDelegate reporter)
        {
            reporterDelegate -= reporter;
        }
    }
}
