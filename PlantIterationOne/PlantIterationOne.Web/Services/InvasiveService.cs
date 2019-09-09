using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlantIterationOne.Web.Data;
using PlantIterationOne.Web.Model;

namespace PlantIterationOne.Web.Services
{
    public class InvasiveService : IInvasiveService
    {
        private readonly PlantContext _context;


        public InvasiveService(PlantContext context)
        {
            _context = context; 
        }


        public async Task<List<Invasive>> GetAllAsync()
        {
            return await _context.Invasives.ToListAsync(); 
        }

        public Task<Invasive> GetByIdAsync(int id)
        {
            return _context.Invasives.FindAsync(id);
        }



        public Task<Invasive> AddAsync(Invasive model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Invasive model)
        {
            throw new NotImplementedException();
        }

       

        public async Task UpdateAsync(Invasive model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
