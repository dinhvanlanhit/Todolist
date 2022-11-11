

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Todolist.Modules._Auth.Models;
using Todolist.Modules._Todo.Models;
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
            var connectionString ="server=113.161.254.75;database=dinhvanlanh_todolist;user=root;password=amnote123";//Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public  DbSet<User> Users { get; set; }
        public  DbSet<Todo> Todos { get; set; }
    }
}