using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Cacu2:AmpCalculator
    {
        public  Cacu2 (Circuit circuit) : base (circuit)
        {
        }

        public override double CalculateAmp() {
            double Resisnum, current;
            Resisnum = (MyCircuit.Resis2 * MyCircuit.Resis4) / (MyCircuit.Resis2 + MyCircuit.Resis4);
            current = Math.Round((MyCircuit.Voltage / (MyCircuit.Resis1 + Resisnum)) + (MyCircuit.Voltage / MyCircuit.Resis3), 3);
            return current;
        }

    }
}
