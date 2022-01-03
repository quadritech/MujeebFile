using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aboru
{
    public class AgbeleService : IAgbeleService
    {
        public AgbeleService()
        {

        }
        public int AdditionCalculator(AdditionCalculatorModel model)
        {

            int sum = model.Num1 + model.Num2;
            return sum;
        }

        public int CalculateAverage(CalculateAverageModel model)
        {
            int sum = model.NumA / model.NumB;
            return sum;

        }
    }
}
