using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherPrognose
{
    public class UniformGenerator : IRandomGenerator
    {
        private Random generator;

        public UniformGenerator(Random generator)
        {
            this.generator = generator;
        }

        public double Generate(double min, double max)
        {
            double a = min;
            return a += generator.NextDouble() * max;
        }
    }
}
