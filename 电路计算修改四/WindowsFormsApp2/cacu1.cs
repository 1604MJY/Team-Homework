using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Cacu1
    {
        static public double Ca1(Circuit circuit)
        {
            double Resisnum, current;
            Resisnum = (circuit.Resis1 * circuit.Resis3) / (circuit.Resis1 + circuit.Resis3);
            current = Math.Round((circuit.Voltage / (circuit.Resis2 + Resisnum)) + (circuit.Voltage / circuit.Resis4), 3);
            return current;


        }
    }
}
