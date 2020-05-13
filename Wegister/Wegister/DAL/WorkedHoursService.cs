using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wegister.DAL.Infra;
using Wegister.Models;

namespace Wegister.DAL
{
    public class WorkedHoursService : IWorkedHoursService
    {
        private readonly WegisterContext _wegisterContext;

        public WorkedHoursService(WegisterContext wegisterContext)
        {
            _wegisterContext = wegisterContext;
        }

        public void RegisterHours(HourRegistration hourRegistration)
        {
            _wegisterContext.Add(hourRegistration);
            _wegisterContext.SaveChanges();
        }

        public List<HourRegistration> GetWorkedHours()
        {
            return _wegisterContext.HourRegistrations.ToList();
        }
    }
}
