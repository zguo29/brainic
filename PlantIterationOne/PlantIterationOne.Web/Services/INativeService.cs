using PlantIterationOne.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantIterationOne.Web.Services
{
    public interface INativeService
    {
        Task<List<Native>> GetAllAsync();
        Task<Native> GetByIdAsync(int id);
        Task<Native> AddAsync(Native model);
        Task UpdateAsync(Native model);
        Task DeleteAsync(Native model);
    }
}
