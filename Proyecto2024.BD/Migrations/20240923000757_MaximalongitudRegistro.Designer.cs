﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto2024.BD.Data;

#nullable disable

namespace Proyecto2024.BD.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240923000757_MaximalongitudRegistro")]
    partial class MaximalongitudRegistro
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proyecto2024.BD.Data.Entity.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Fecha_nac")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Fecha_registro")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("IdRegistro")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("NumDoc")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("RegistroId")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegistroId");

                    b.HasIndex(new[] { "Apellido", "Nombre" }, "Persona_Apellido_Nombre");

                    b.HasIndex(new[] { "IdRegistro", "NumDoc" }, "Persona_UQ")
                        .IsUnique();

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Proyecto2024.BD.Data.Entity.Registro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Codigo" }, "Registro_UQ")
                        .IsUnique();

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("Proyecto2024.BD.Data.Entity.Persona", b =>
                {
                    b.HasOne("Proyecto2024.BD.Data.Entity.Registro", "Registro")
                        .WithMany()
                        .HasForeignKey("RegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registro");
                });
#pragma warning restore 612, 618
        }
    }
}
