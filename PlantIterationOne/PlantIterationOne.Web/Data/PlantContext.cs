using Microsoft.EntityFrameworkCore;
using PlantIterationOne.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantIterationOne.Web.Data
{
    public class PlantContext:DbContext
    {
        public PlantContext(DbContextOptions<PlantContext> options) : base(options)
        {

        }

        public DbSet<Native> Natives { get; set; }
        public DbSet<Invasive> Invasives { get; set; }

    }
}
