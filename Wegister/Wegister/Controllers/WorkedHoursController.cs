using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wegister.DAL;
using Wegister.DAL.Infra;
using Wegister.Models;

namespace Wegister.Controllers
{
    //[Authorize]
    [Route("[controller]")]
    [ApiController]
    public class WorkedHoursController : ControllerBase
    {
        private IWorkedHoursService _workedHoursService;

        public WorkedHoursController(IWorkedHoursService workedHoursService)
        {
            _workedHoursService = workedHoursService;
        }

        [HttpGet]
        public IEnumerable<HourRegistration> GetHours()
        {
            return _workedHoursService.GetWorkedHours();
        }

        [HttpPost]
        public void RegisterHours([FromBody] HourRegistration hourRegistration)
        {
            _workedHoursService.RegisterHours(hourRegistration);
        }
    }
}