using APIProductos.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace APIProductos.Data
{
    public class AplicationDBContext :DbContext
    {
        public AplicationDBContext(
            DbContextOptions<AplicationDBContext> options) : base(options)

        {
            
        }

        public DbSet<Producto> Producto { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(

                new Producto
                {
                    IdProducto = 1,
                    Nombre="Producto1",
                    Descripcion="Producto1",
                    cantidad=2
                },
                new Producto
                {
                    IdProducto = 2,
                    Nombre="Producto2",
                    Descripcion="Producto2",
                    cantidad=324
                }


                );
        }
    }
}
