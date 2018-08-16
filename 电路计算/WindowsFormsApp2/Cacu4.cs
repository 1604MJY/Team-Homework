using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Cacu4
    {
        static public double Ca4(Circuit circuit)
        {
            double Resisnum, current;
            Resisnum = circuit.Resis1 + circuit.Resis2+ circuit.Resis3;
            current = Math.Round((circuit.Voltage /Resisnum), 3);
            return current;
        }
    }
}
