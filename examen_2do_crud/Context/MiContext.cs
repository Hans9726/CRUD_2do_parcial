using examen_2do_crud.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace examen_2do_crud.Context
{
    public class MiContext: DbContext
    {
        public  MiContext (DbContextOptions options): base(options)
        {
        
        }
        public DbSet<Producto> Productos { get; set; }
        
    }
}
