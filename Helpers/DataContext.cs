

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Todolist.Models;
namespace  Todolist.Helpers
{
    public class DataContext : DbContext
    {
        // public IConfiguration Configuration { get; }

        // public DataContext(IConfiguration configuration)
        // {
        //     Configuration = configuration;
        // }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
          
            // connect to mysql with connection string from app settings
            var connectionString ="server=localhost;database=dinhvanlanh_todolist;user=root;";//Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public  DbSet<User> Users { get; set; }
        public  DbSet<Todo> Todos { get; set; }
    }
}