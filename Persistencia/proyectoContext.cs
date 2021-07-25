using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
    public class proyectoContext : DbContext
    {
        public DbSet<Producto> productos { get; set; }
        public DbSet<Ventas> ventas { get; set; }
        public DbSet<Compras> compras { get; set; }
        public DbSet<Estado> estados { get; set; }
        public DbSet<Registro> registros { get; set; }
        // Constructor vacio
        public proyectoContext() : base()
        {

        }

        // Constructor para pasar la conexión al padre
        public proyectoContext(DbContextOptions<proyectoContext> opciones) : base(opciones)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ventas>()
                .HasOne(ven => ven.Producto)
                .WithMany(pro => pro.Ventas)
                .HasForeignKey(ven => ven.ProductoId);
            modelBuilder.Entity<Ventas>()
                .HasOne(ven => ven.Estado)
                .WithMany(est => est.Ventas)
                .HasForeignKey(ven => ven.EstadoId);
            modelBuilder.Entity<Compras>()
                .HasOne(com => com.Producto)
                .WithMany(pro => pro.Compras)
                .HasForeignKey(com => com.ProductoId);
            modelBuilder.Entity<Compras>()
                .HasOne(com => com.Estado)
                .WithMany(est => est.Compras)
                .HasForeignKey(com => com.EstadoId);
            modelBuilder.Entity<Compras>()
                .HasOne(com => com.Registro)
                .WithMany(reg => reg.Compras)
                .HasForeignKey(com => com.RegistroId);
            modelBuilder.Entity<Ventas>()
               .HasOne(ven => ven.Registro)
               .WithMany(reg => reg.Ventas)
               .HasForeignKey(ven => ven.RegistroId);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                proyectoConfig.ContextOptions(optionsBuilder);
            }
        }

    }
}
