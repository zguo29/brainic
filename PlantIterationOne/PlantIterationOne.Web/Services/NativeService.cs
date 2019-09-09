using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlantIterationOne.Web.Data;
using PlantIterationOne.Web.Model;

namespace PlantIterationOne.Web.Services
{
    public class NativeService : INativeService
    {

        private readonly PlantContext _context; 

        public NativeService(PlantContext context)
        {
            _context = context; 
        }

        public async Task<List<Native>> GetAllAsync()
        {
            return await _context.Natives.ToListAsync(); 
        }


        public Task<Native> GetByIdAsync(int id)
        {
            return _context.Natives.FindAsync(id);
        }
        public async Task UpdateAsync(Native model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }







        public Task<Native> AddAsync(Native model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Native model)
        {
            throw new NotImplementedException();
        }

        
        

        
    }
}
