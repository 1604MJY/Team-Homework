using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Circuit
    {
        public double Voltage;
        public double Resis1;
        public double Resis2;
        public double Resis3;
        public double Resis4;

        public Circuit() { }

        public Circuit(double voltage, double resis1, double resis2, double resis3, double resis4)
        {
            Voltage = voltage;
            Resis1 = resis1;
            Resis2 = resis2;
            Resis3 = resis3;
            Resis4 = resis4;
        }
    }
}
