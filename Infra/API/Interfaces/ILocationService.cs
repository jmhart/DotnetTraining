using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.API;


namespace Infra.API.Interfaces
{
    public interface ILocationService
    {
        Task<Location?> GetLocationAsync(string city, string state);
    }
}