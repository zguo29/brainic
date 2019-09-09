using PlantIterationOne.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantIterationOne.Web.Services
{
    public interface IInvasiveService
    {
        Task<List<Invasive>> GetAllAsync();
        Task<Invasive> GetByIdAsync(int id);
        Task<Invasive> AddAsync(Invasive model);
        Task UpdateAsync(Invasive model);
        Task DeleteAsync(Invasive model);
    }
}
