using Microsoft.EntityFrameworkCore;
using pizza_restaurant.Models;

namespace pizza_restaurant.Data
{
    // Le DataContext permet à Entity de gérer les accès à la BDD en déclarant des DbSet.
    public class DataContext : DbContext 
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        }

        public DbSet<Pizza> Pizzas { get; set; }

    }
}
