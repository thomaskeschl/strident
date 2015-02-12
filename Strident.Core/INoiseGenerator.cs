using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strident.Core
{
    public interface INoiseGenerator
    {
        double noiseAt(double x, double y);

        double noiseAt(double x, double y, double z);
    }
}
