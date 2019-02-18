﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartU2.Models;

namespace SmartU2.Migrations
{
    [DbContext(typeof(SmartU2Context))]
    [Migration("20190218193305_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmartU2.Models.SlotParqueadero", b =>
                {
                    b.Property<int>("IdSlotParqueadero")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Estado");

                    b.Property<string>("Placa");

                    b.Property<string>("PuntoCardinalx");

                    b.Property<string>("PuntoCardinaly");

                    b.HasKey("IdSlotParqueadero");

                    b.ToTable("SlotParqueadero");
                });

            modelBuilder.Entity("SmartU2.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cedula");

                    b.Property<string>("Contrasena");

                    b.Property<string>("Correo");

                    b.Property<bool>("Estado");

                    b.Property<string>("Nombre");

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SmartU2.Models.Zona", b =>
                {
                    b.Property<int>("IdZona")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidad");

                    b.Property<string>("Nombre");

                    b.HasKey("IdZona");

                    b.ToTable("Zona");
                });
#pragma warning restore 612, 618
        }
    }
}
