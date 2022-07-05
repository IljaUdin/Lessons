using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cinema.Entities;

namespace Cinema.DB;

public class AppDbContext : DbContext
{
    public DbSet<Film> Films { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<CompanyFilm> CompanyFilms { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<Serial> Serials { get; set; }

    
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {

    }
    
    public AppDbContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CinemaDb;Username=postgres;Password=admin");
        //optionsBuilder.UseNpgsql(b => b.MigrationsAssembly("Cinema.API"));
    }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Film>().Property(x => x.Name).HasColumnType("varchar(200)");

        modelBuilder.Entity<CompanyFilm>().HasKey(x => new { x.CompanyId, x.FilmId });

        base.OnModelCreating(modelBuilder);
    }

    
}
