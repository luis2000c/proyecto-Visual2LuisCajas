﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(proyectoContext))]
    partial class proyectoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.Compras", b =>
                {
                    b.Property<int>("ComprasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CostoTotal")
                        .HasColumnType("real");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("RegistroId")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.HasKey("ComprasId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("ProductoId");

                    b.HasIndex("RegistroId");

                    b.ToTable("compras");
                });

            modelBuilder.Entity("Modelo.Estado", b =>
                {
                    b.Property<int>("Estadoid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomEstado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Estadoid");

                    b.ToTable("estados");
                });

            modelBuilder.Entity("Modelo.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("costoUnitario")
                        .HasColumnType("real");

                    b.Property<string>("nomProducto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductoId");

                    b.ToTable("productos");
                });

            modelBuilder.Entity("Modelo.Registro", b =>
                {
                    b.Property<int>("RegistroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.HasKey("RegistroId");

                    b.ToTable("registros");
                });

            modelBuilder.Entity("Modelo.Ventas", b =>
                {
                    b.Property<int>("VentasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CostoTotal")
                        .HasColumnType("real");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("RegistroId")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.HasKey("VentasId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("ProductoId");

                    b.HasIndex("RegistroId");

                    b.ToTable("ventas");
                });

            modelBuilder.Entity("Modelo.Compras", b =>
                {
                    b.HasOne("Modelo.Estado", "Estado")
                        .WithMany("Compras")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Producto", "Producto")
                        .WithMany("Compras")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Registro", "Registro")
                        .WithMany("Compras")
                        .HasForeignKey("RegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");

                    b.Navigation("Producto");

                    b.Navigation("Registro");
                });

            modelBuilder.Entity("Modelo.Ventas", b =>
                {
                    b.HasOne("Modelo.Estado", "Estado")
                        .WithMany("Ventas")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Producto", "Producto")
                        .WithMany("Ventas")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Registro", "Registro")
                        .WithMany("Ventas")
                        .HasForeignKey("RegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");

                    b.Navigation("Producto");

                    b.Navigation("Registro");
                });

            modelBuilder.Entity("Modelo.Estado", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Modelo.Producto", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Modelo.Registro", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
