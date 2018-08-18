using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Cacu3:AmpCalculator
    {
        public  Cacu3(Circuit circuit) : base(circuit)
        {
        }
        public override double CalculateAmp()
        {
            double Resisnum, current;
            Resisnum = 1 / (1 / MyCircuit.Resis1 + 1 / MyCircuit.Resis2 + 1 / MyCircuit.Resis3);
            current = Math.Round((MyCircuit.Voltage / Resisnum), 3);
            return current;

        }
  


        
    }
}
