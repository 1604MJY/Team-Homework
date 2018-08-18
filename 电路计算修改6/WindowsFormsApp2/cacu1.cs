using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{                                      
    public class Cacu1:AmpCalculator
    {
        public Cacu1(Circuit circuit) : base(circuit)
        {
        }

        public override double CalculateAmp()
        {
            double Resisnum, current;
            Resisnum = (MyCircuit.Resis1 * MyCircuit.Resis3) / (MyCircuit.Resis1 + MyCircuit.Resis3);
            current = Math.Round((MyCircuit.Voltage / (MyCircuit.Resis2 + Resisnum)) + (MyCircuit.Voltage / MyCircuit.Resis4), 3);
            return current;

        }

    }
}
