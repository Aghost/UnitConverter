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

        [HttpGet("/convert/{val}/{unit1}/{unit2}")]
        public string Convert(double val, string unit1, string unit2) {
            if (ParseInput($"{val} {unit1} {unit2}", LengthUnits, ConvertUnit, out string buffer)) {
                _logger.LogInformation($"SUCCESS: API-ParseInput: [{val} {unit1} {unit2}]");
            } else {
                _logger.LogInformation($"FAIL: API-ParseInput: [{val} {unit1} {unit2}] {buffer}");
            }

            return buffer;
        }
    }
}
