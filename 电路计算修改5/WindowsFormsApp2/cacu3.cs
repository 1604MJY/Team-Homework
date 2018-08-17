using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Cacu3
    {
        static public double Ca3(Circuit circuit)
        {
            double Resisnum, current;
            Resisnum = 1/(1/circuit.Resis1+1/circuit.Resis2+1/circuit.Resis3);
            current = Math.Round((circuit.Voltage/Resisnum ), 3);
            return current;


        }
    }
}
