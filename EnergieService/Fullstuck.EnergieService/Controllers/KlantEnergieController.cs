using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fullstuck.EnergieService.Models;
using Microsoft.AspNetCore.Mvc;
using Fullstuck.EnergieService.BLL;

namespace Fullstuck.EnergieService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KlantEnergieController : Controller
    {
        private readonly IEnergieCalculationLogic _energieCalculationLogic;
        private readonly IEnergiemeterLogic _energiemeterLogic;

        public KlantEnergieController(IEnergieCalculationLogic energiemeterCalculationLogic, IEnergiemeterLogic energiemeterLogic)
        {
            _energieCalculationLogic = energiemeterCalculationLogic;
            _energiemeterLogic = energiemeterLogic;
        }

        [Route("{meterId}/balans/{jaar}")]
        [HttpGet]
        public List<EnergieMeting> GetBalansPerJaar([FromRoute] int meterId, [FromRoute] int jaar)
        {
            return _energiemeterLogic.GetBalans(meterId, jaar);
        }

        [Route("{meterId}/opbrengst/{jaar}")]
        [HttpGet]
        public List<EnergieMeting> GetOpbrengstPerJaar([FromRoute] int meterId, [FromRoute] int jaar)
        {
            return _energiemeterLogic.GetMetingPerJaar(GebruiksType.Opbrengst, meterId, jaar);
        }

        [Route("{meterId}/verbruik/{jaar}")]
        [HttpGet]
        public List<EnergieMeting> GetVerbruikPerJaar([FromRoute] int meterId, [FromRoute] int jaar)
        {
            return _energiemeterLogic.GetMetingPerJaar(GebruiksType.Verbruik, meterId, jaar);
        }
    }
}