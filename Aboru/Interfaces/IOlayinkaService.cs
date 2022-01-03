using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aboru
{
    public interface IOlayinkaService
    {

        int MultiplicationTable(MultiplicationModel model);
        double CalculateDensity(DensityModel model);
    }
}
