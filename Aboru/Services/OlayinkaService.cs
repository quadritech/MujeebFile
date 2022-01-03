using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aboru
{
    public class OlayinkaService:IOlayinkaService
    {
        //private readonly Interface nickName;
        private readonly IAgbeleService _agbeleService;

        public OlayinkaService(IAgbeleService agbeleService)
        {
            _agbeleService = agbeleService;
        }

        public int MultiplicationTable(MultiplicationModel model)
        {
            return 0;
        }

        public double CalculateDensity(DensityModel model)
        {
            double calculate = model.Mass / model.Volume;
            return calculate;
        }

       public double AverageDivisor(int numA, int numB, int divisor)
        {
            //instantiating model in method
            CalculateAverageModel model = new CalculateAverageModel
            {
                NumA = numA,
                NumB = numB
            };

            int average = _agbeleService.CalculateAverage(model);
            double result = average / divisor;
            return result;
        }
        
    }
}
