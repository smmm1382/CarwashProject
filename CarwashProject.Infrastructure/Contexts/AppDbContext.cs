using CarwashProject.Application.Interfaces;
using CarwashProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Infrastructure.Contexts;

public class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Worker> Workers { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Car> Cars { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Worker>().HasData(new List<Worker>()
        {
           new Worker{Id = 1,Age = 20,FirstName = "ali",LastName = "ahmadi",},
           new Worker{Id = 2,Age = 21,FirstName = "majid",LastName = "majidi"},
           new Worker{Id = 3,Age = 22,FirstName = "farhad",LastName = "farhadi"},
           new Worker{Id = 4,Age = 23,FirstName = "soheil",LastName = "soheily"}
        });

        modelBuilder.Entity<Service>().HasData(new List<Service>()
        {
            new Service{Id = 1,Name = "Roshoyee",Price = 60000},
            new Service{Id = 2,Name = "Broom",Price = 40000},
            new Service{Id = 3,Name = "Wax",Price = 40000},
            new Service{Id = 4,Name = "EngineWash",Price = 70000}
        });

        base.OnModelCreating(modelBuilder);
    }
}

