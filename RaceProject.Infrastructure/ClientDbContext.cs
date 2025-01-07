using Microsoft.EntityFrameworkCore;
using RaceProject.Domain.Entities;
namespace RaceProject.Infrastructure;

public class ClientDbContext : DbContext
{
    public ClientDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Client> Clients { get; set; }

    

}