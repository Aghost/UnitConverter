using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static MeterConverter.Domain.UnitConverter;

namespace MeterConverter.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeterConverterController : ControllerBase {
        private readonly ILogger<MeterConverterController> _logger;

        public MeterConverterController(ILogger<MeterConverterController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public string Get() {
            return $"testing";
        }

        [HttpGet("/convert/{val}/{unit1}/{unit2}")]
        public string Convert(double val, string unit1, string unit2) {
            string tmp = ParseInput($"{val} {unit1} {unit2}", LengthUnits);
            _logger.LogInformation($"API: [{val} {unit1} {unit2}] {tmp}");
            return tmp;
        }
    }
}