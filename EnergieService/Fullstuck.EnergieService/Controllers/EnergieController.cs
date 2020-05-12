using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fullstuck.EnergieService.BLL;
using Fullstuck.EnergieService.DAL;
using Fullstuck.EnergieService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fullstuck.EnergieService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnergieController : ControllerBase
    {
        private readonly IEnergieCalculationLogic _energieCalculationLogic;
        private readonly IEnergieLogic _energieLogic;

        public EnergieController(IEnergieCalculationLogic energieCalculationLogic, IEnergieLogic energieLogic)
        {
            _energieCalculationLogic = energieCalculationLogic;
            _energieLogic = energieLogic;
        }

        //THIS METHOD WILL BE DELETED IN THE SECOND PATCH
        [Route("balans")]
        [HttpGet]
        public List<EnergieMeting> GetBalansPerJaar()
        {
            return _energieLogic.GetBalans(2019);
        }

        [Route("balans/{jaar}")]
        [HttpGet]
        public List<EnergieMeting> GetBalansPerJaar([FromRoute] int jaar)
        {
            return _energieLogic.GetBalans(jaar);
        }

        [Route("verbruik/{jaar}/{maand}/{dag}")]
        [HttpGet]
        public List<EnergieMeting> GetVerbruikPerDag([FromRoute] int jaar, [FromRoute] int maand, [FromRoute] int dag)
        {

            return _energieLogic.GetMetingPerDag(GebruiksType.Verbruik, jaar, maand, dag);
        }

        [Route("verbruik/{jaar}/{maand}")]
        [HttpGet]
        public List<EnergieMeting> GetVerbruikPerMaand([FromRoute] int jaar, [FromRoute] int maand)
        {

            return _energieLogic.GetMetingPerMaand(GebruiksType.Verbruik, jaar, maand);
        }

        [Route("verbruik/{jaar}")]
        [HttpGet]
        public List<EnergieMeting> GetVerbruikPerJaar([FromRoute] int jaar)
        {
            return _energieLogic.GetMetingPerJaar(GebruiksType.Verbruik, jaar);
        }

        [Route("opbrengst/{jaar}/{maand}/{dag}")]
        [HttpGet]
        public List<EnergieMeting> GetOpbrengstPerDag([FromRoute] int jaar, [FromRoute] int maand, [FromRoute] int dag)
        {
            return _energieLogic.GetMetingPerDag(GebruiksType.Opbrengst, jaar, maand, dag);
        }

        [Route("opbrengst/{jaar}/{maand}")]
        [HttpGet]
        public List<EnergieMeting> GetOpbrengstPerMaand([FromRoute] int jaar, [FromRoute] int maand)
        {
            return _energieLogic.GetMetingPerMaand(GebruiksType.Opbrengst, jaar, maand);
        }

        [Route("opbrengst/{jaar}")]
        [HttpGet]
        public List<EnergieMeting> GetOpbrengstPerJaar([FromRoute] int jaar)
        {
            return _energieLogic.GetMetingPerJaar(GebruiksType.Opbrengst, jaar);
        }
    }
}