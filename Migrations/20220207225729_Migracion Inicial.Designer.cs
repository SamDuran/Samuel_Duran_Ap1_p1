﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Samuel_Duran_Ap1_p1_.DAL;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Samuel_Duran_Ap1_p1_.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220207225729_Migracion Inicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ValorInventario")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
