﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppCrudEf.Models;

#nullable disable

namespace WebAppCrudEf.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240902140838_AlumnosController")]
    partial class AlumnosController
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAppCrudEf.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnioIngreso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<int>("Legajo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarreraId");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("WebAppCrudEf.Models.Carrera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("WebAppCrudEf.Models.Domicilio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<int>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId")
                        .IsUnique();

                    b.ToTable("Domicilios");
                });

            modelBuilder.Entity("WebAppCrudEf.Models.Alumno", b =>
                {
                    b.HasOne("WebAppCrudEf.Models.Carrera", "Carrera")
                        .WithMany("Alumnos")
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");
                });

            modelBuilder.Entity("WebAppCrudEf.Models.Domicilio", b =>
                {
                    b.HasOne("WebAppCrudEf.Models.Alumno", null)
                        .WithOne("Domicilio")
                        .HasForeignKey("WebAppCrudEf.Models.Domicilio", "AlumnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAppCrudEf.Models.Alumno", b =>
                {
                    b.Navigation("Domicilio")
                        .IsRequired();
                });

            modelBuilder.Entity("WebAppCrudEf.Models.Carrera", b =>
                {
                    b.Navigation("Alumnos");
                });
#pragma warning restore 612, 618
        }
    }
}
