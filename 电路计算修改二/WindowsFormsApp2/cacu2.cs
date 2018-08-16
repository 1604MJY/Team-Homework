using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Cacu2
    {
        static public double Ca2(Circuit circuit)
        { double Resisnum,current;
            Resisnum = (circuit.Resis2 * circuit.Resis4) / (circuit.Resis2 + circuit.Resis4);
            current = Math.Round((circuit.Voltage / (circuit.Resis1 + Resisnum)) + (circuit.Voltage / circuit.Resis3),3);
            return current;
        }
    }
}
