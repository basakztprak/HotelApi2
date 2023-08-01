using HotelApi2.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Infastructure.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<CustomerRooms> CustomerRooms { get; set; }
        public DbSet<Customers> Customers { get; set; } 
        public DbSet<Rooms> Rooms { get; set; }

    }
}
