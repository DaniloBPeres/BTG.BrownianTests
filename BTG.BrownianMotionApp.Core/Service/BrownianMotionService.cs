using BTG.BrownianTests.Core.Interface;
using BTG.BrownianTests.Core.Models;

namespace BTG.BrownianMotianApp.Core.Service
{
    public class BrownianMotionService : IBrownianMotionService
    {
        private readonly Random _random = new();

        public BrownianResult Generate(BrownianParameters parameters)
        {
            if (parameters.InitialPrice <= 0 || parameters.Paths <= 0 || parameters.Duration <= 0)
            {
                return new BrownianResult { Paths = new List<List<double>>() };
            }

            var result = new BrownianResult();

            for(int pathIndex = 0; pathIndex < parameters.Paths; pathIndex++)
            {
                var path = new List<double>() { parameters.InitialPrice };

                for (int t = 1; t <= parameters.Duration; t++)
                {
                    double prev = path[t - 1];
                    double dt = 1.0;//1 dia
                    double drift = (parameters.MeanReturn - 0.5 * Math.Pow(parameters.Volatility, 2)) * dt;
                    double diffusion = parameters.Volatility * Math.Sqrt(dt) * NextGaussian();

                    double nextPrice = prev * Math.Exp(drift + diffusion);
                    path.Add(nextPrice);
                }

                result.Paths.Add(path);
            }

            return result;
        }

        private double NextGaussian()
        {
            double u1 = _random.NextDouble();
            double u2 = _random.NextDouble();
            return Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);
        }
    }
}
