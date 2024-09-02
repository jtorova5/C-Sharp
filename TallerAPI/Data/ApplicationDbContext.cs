using Microsoft.EntityFrameworkCore;
using TallerAPI.Models;

namespace TallerAPI.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Propietario> Propietarios { get; set; }
    public DbSet<Vehiculo> Vehiculos { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}
