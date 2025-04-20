using System.Configuration;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Zakázky.DB_Class;

namespace Zakázky;

public class MainDBContext : DbContext
{
    public DbSet<AdressList> AdressList { get; set; }
    public DbSet<ContactList> ContactList { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrderItem> OrderItem { get; set; }
    public DbSet<Subject> Subject { get; set; }
    public DbSet<BindingSubjectToAdress> BindingSubjectToAdress { get; set; }
    public DbSet<BindingSubjectToContact> BindingSubjectToContact { get; set; }

    /*
     * dotnet ef migrations add NAZEV_MIGRACE
     * dotnet ef database update
     */
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Debug.WriteLine(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
    }
}