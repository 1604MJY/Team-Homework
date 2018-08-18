using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Cacu4:AmpCalculator 
    {
      public Cacu4(Circuit circuit):base(circuit)
        {
        }
        public override double CalculateAmp()
        {
            double Resisnum, current;
            Resisnum = MyCircuit .Resis1 + MyCircuit.Resis2 + MyCircuit.Resis3;
            current = Math.Round((MyCircuit.Voltage /Resisnum), 3);
            return current;
        }

        
    }
}
