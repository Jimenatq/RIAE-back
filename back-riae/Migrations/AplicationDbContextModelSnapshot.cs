﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using back_riae.Models;

#nullable disable

namespace backriae.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("back_riae.Models.subtipo_ingresos", b =>
                {
                    b.Property<int>("id_subtipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_subtipo"));

                    b.Property<int>("id_tipo_registro")
                        .HasColumnType("int");

                    b.Property<string>("nombre_subtipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("subtipo_registro")
                        .HasColumnType("int");

                    b.HasKey("id_subtipo");

                    b.HasIndex("id_tipo_registro");

                    b.ToTable("subtipo_Ingresos");
                });

            modelBuilder.Entity("back_riae.Models.tipos_ingresos", b =>
                {
                    b.Property<int>("id_tipo_registro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_tipo_registro"));

                    b.Property<string>("nombre_registro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipo_registro")
                        .HasColumnType("int");

                    b.HasKey("id_tipo_registro");

                    b.ToTable("tipos_Registros");
                });

            modelBuilder.Entity("back_riae.Models.subtipo_ingresos", b =>
                {
                    b.HasOne("back_riae.Models.tipos_ingresos", "tipos_ingresos")
                        .WithMany()
                        .HasForeignKey("id_tipo_registro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tipos_ingresos");
                });
#pragma warning restore 612, 618
        }
    }
}
