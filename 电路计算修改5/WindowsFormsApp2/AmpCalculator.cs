using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public abstract class AmpCalculator
    {
        public Circuit MyCircuit { get;  }

        public AmpCalculator(Circuit circuit)
        {
            MyCircuit = circuit;
        }

 
        public virtual double CalculateAmp()
        {
            throw new NotImplementedException();
        }
    }
}
