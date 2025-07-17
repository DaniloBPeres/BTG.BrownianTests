using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTG.BrownianTests.Core.Models
{
    public class BrownianParameters
    {
        public double InitialPrice { get; set; }
        public double Volatility { get; set; }
        public double MeanReturn { get; set; }
        public int Duration { get; set; }
        public int Paths { get; set; } = 1;
    }
}
