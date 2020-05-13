using System.Collections.Generic;
using Wegister.Models;

namespace Wegister.DAL.Infra
{
    public interface IWorkedHoursService
    {
        void RegisterHours(HourRegistration hourRegistration);
        List<HourRegistration> GetWorkedHours();
    }
}