using Aboru;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MujeebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboruController : ControllerBase
    {
        private readonly IAgbeleService _agbeleService;

        public AboruController(IAgbeleService agbeleService)
        {
            _agbeleService = agbeleService;
        }


        //endpoint
        public ActionResult<int> Addition(int a, int b)
        {
            AdditionCalculatorModel model = new AdditionCalculatorModel
            {
                Num1 = a,
                Num2 = b
            };

            var result = _agbeleService.AdditionCalculator(model);
            return result;
        }

        public ActionResult<int> Average(int a, int b)
        {
            CalculateAverageModel model = new CalculateAverageModel()
            {
                NumA = a,
                NumB = b
            };

            var result = _agbeleService.CalculateAverage(model);
            return result;
        }
    }
}
