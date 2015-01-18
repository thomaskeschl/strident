using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strident.Core
{
    class NoiseGeneratorFactory
    {
        public INoiseGenerator createSimplexGenerator() {
            return new SimplexNoiseGenerator();
        }
    }
}
