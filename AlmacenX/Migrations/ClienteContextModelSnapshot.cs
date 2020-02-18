﻿// <auto-generated />
using AlmacenX.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlmacenX.Migrations
{
    [DbContext(typeof(ClienteContext))]
    partial class ClienteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlmacenX.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Correo")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Direccion")
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Estado");

                    b.Property<string>("Genero")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
