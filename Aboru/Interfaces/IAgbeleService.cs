using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aboru
{
    public interface IAgbeleService
    {

        int AdditionCalculator(AdditionCalculatorModel model);
        int CalculateAverage(CalculateAverageModel model);
    }
}
