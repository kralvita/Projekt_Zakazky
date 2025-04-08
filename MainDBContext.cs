using System.Configuration;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Zakázky.DB_Class;

namespace Zakázky;

public class MainDBContext : DbContext
{
    public DbSet<Subject> Subject { get; set; }
    public DbSet<ContactList> ContactList { get; set; }

    public DbSet<AdressList> AdressList { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Debug.WriteLine(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
    }
}