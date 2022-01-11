using Aboru;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MujeebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OlayinkaController : ControllerBase
    {
        private readonly IOlayinkaService _olayinkaService;

        public OlayinkaController(Aboru.IOlayinkaService olayinkaService)
        {
            _olayinkaService = olayinkaService;
        }

        public ActionResult<int> Multiplication(int Length, int Breadth)
        {
            MultiplicationModel model = new MultiplicationModel()
            {
                Lenght = Length,
                Breadth = Breadth,
            };

            var result = _olayinkaService.MultiplicationTable(model);
            return result;
        }


        public ActionResult<double> CalculateDensity(double MassA, double VolumeB)
        {
            DensityModel model = new DensityModel()
            {
                Mass = MassA,
                Volume = VolumeB
            };
            var result = _olayinkaService.CalculateDensity(model);
            return result;

        }

    }
}
