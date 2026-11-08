using AppDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace AppDemo.Data
{
    public class AppDbContext : DbContext
    {
        //Paso 1 constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //Paso 2 Añadir la Entidad al Contexto.
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
