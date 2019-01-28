using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volvo.Trucks.App.Models;

namespace Volvo.Trucks.App.Models
{
    public class VolvoTrucksContext : DbContext
    {
        public VolvoTrucksContext (DbContextOptions<VolvoTrucksContext> options)
            : base(options)
        {
        }

        public DbSet<Volvo.Trucks.App.Models.TruckModel> TruckModel { get; set; }

        public DbSet<Volvo.Trucks.App.Models.Truck> Truck { get; set; }
    }
}
