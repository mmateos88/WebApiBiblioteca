﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiBiblioteca;

#nullable disable

namespace WebApiBiblioteca.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220612172124_completa")]
    partial class completa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApiBiblioteca.Entidades.Editorial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Editoriales");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Susaeta"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Anaya"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Minotauro"
                        });
                });

            modelBuilder.Entity("WebApiBiblioteca.Entidades.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EditorialId")
                        .HasColumnType("int");

                    b.Property<int>("Paginas")
                        .HasPrecision(1, 5)
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("EditorialId");

                    b.ToTable("Libros");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EditorialId = 1,
                            Paginas = 14,
                            Titulo = "Mi primer atlas"
                        },
                        new
                        {
                            Id = 2,
                            EditorialId = 1,
                            Paginas = 10,
                            Titulo = "Circula por la ciudad"
                        },
                        new
                        {
                            Id = 3,
                            EditorialId = 1,
                            Paginas = 32,
                            Titulo = "Mi mascota el dinosaurio"
                        },
                        new
                        {
                            Id = 4,
                            EditorialId = 2,
                            Paginas = 160,
                            Titulo = "Alma de elefante"
                        },
                        new
                        {
                            Id = 5,
                            EditorialId = 2,
                            Paginas = 120,
                            Titulo = "En un bosque de hoja caduca"
                        },
                        new
                        {
                            Id = 6,
                            EditorialId = 2,
                            Paginas = 112,
                            Titulo = "La primera tarde después de navidad"
                        },
                        new
                        {
                            Id = 7,
                            EditorialId = 2,
                            Paginas = 152,
                            Titulo = "El arca y yo"
                        },
                        new
                        {
                            Id = 8,
                            EditorialId = 2,
                            Paginas = 248,
                            Titulo = "Las chicas de la 305"
                        },
                        new
                        {
                            Id = 9,
                            EditorialId = 3,
                            Paginas = 504,
                            Titulo = "La naturaleza de la tierra media"
                        },
                        new
                        {
                            Id = 10,
                            EditorialId = 3,
                            Paginas = 344,
                            Titulo = "Sinopsis de cine"
                        });
                });

            modelBuilder.Entity("WebApiBiblioteca.Entidades.Libro", b =>
                {
                    b.HasOne("WebApiBiblioteca.Entidades.Editorial", "Editorial")
                        .WithMany("Libros")
                        .HasForeignKey("EditorialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Editorial");
                });

            modelBuilder.Entity("WebApiBiblioteca.Entidades.Editorial", b =>
                {
                    b.Navigation("Libros");
                });
#pragma warning restore 612, 618
        }
    }
}
