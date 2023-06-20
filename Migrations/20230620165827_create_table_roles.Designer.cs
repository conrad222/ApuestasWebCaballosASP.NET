﻿// <auto-generated />
using System;
using ApuestasWebCaballos.Models.DataAcces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApuestasWebCaballos.Migrations
{
    [DbContext(typeof(CarreraswebContext))]
    [Migration("20230620165827_create_table_roles")]
    partial class create_table_roles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_general_ci")
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("ApuestasWebCaballos.Models.DataAcces.Apuestum", b =>
                {
                    b.Property<uint>("IdApuesta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11) unsigned zerofill")
                        .HasColumnName("id_apuesta");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha");

                    b.HasKey("IdApuesta")
                        .HasName("PRIMARY");

                    b.ToTable("apuesta", (string)null);
                });

            modelBuilder.Entity("ApuestasWebCaballos.Models.DataAcces.Caballo", b =>
                {
                    b.Property<int>("IdCaballo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_caballo");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<string>("Pigmentacion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("pigmentacion");

                    b.Property<string>("Sexo")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("sexo");

                    b.HasKey("IdCaballo")
                        .HasName("PRIMARY");

                    b.ToTable("caballo", (string)null);
                });

            modelBuilder.Entity("ApuestasWebCaballos.Models.DataAcces.Hipodromo", b =>
                {
                    b.Property<int>("IdHipodromo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_hipodromo");

                    b.Property<string>("Direccion")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("direccion");

                    b.HasKey("IdHipodromo")
                        .HasName("PRIMARY");

                    b.ToTable("hipodromo", (string)null);
                });

            modelBuilder.Entity("ApuestasWebCaballos.Models.DataAcces.Jockey", b =>
                {
                    b.Property<int>("IdJockey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_jockey");

                    b.Property<string>("ColorEquipo")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("color_equipo");

                    b.Property<int?>("Copas")
                        .HasColumnType("int(11)")
                        .HasColumnName("copas");

                    b.Property<int?>("Numero")
                        .HasColumnType("int(11)")
                        .HasColumnName("numero");

                    b.HasKey("IdJockey")
                        .HasName("PRIMARY");

                    b.ToTable("jockey", (string)null);
                });

            modelBuilder.Entity("ApuestasWebCaballos.Models.DataAcces.Rol", b =>
                {
                    b.Property<int?>("IdRol")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_rol");

                    b.Property<string>("Rol1")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("rol");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("ApuestasWebCaballos.Models.DataAcces.Trabajador", b =>
                {
                    b.Property<int>("IdTrabajador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_trabajador");

                    b.Property<string>("Apellido")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("apellido");

                    b.Property<double?>("CajaApuesta")
                        .HasColumnType("double")
                        .HasColumnName("caja_apuesta");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("IdTrabajador")
                        .HasName("PRIMARY");

                    b.ToTable("trabajador", (string)null);
                });

            modelBuilder.Entity("ApuestasWebCaballos.Models.DataAcces.Usuario", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("user_id");

                    b.Property<string>("Contraseña")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("contraseña");

                    b.Property<string>("Correo")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("correo");

                    b.Property<double?>("Dinero")
                        .HasColumnType("double")
                        .HasColumnName("dinero");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("UserId")
                        .HasName("PRIMARY");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("ApuestasWebCaballos.Models.DataAcces.Jockey", b =>
                {
                    b.HasOne("ApuestasWebCaballos.Models.DataAcces.Caballo", "IdJockeyNavigation")
                        .WithOne("Jockey")
                        .HasForeignKey("ApuestasWebCaballos.Models.DataAcces.Jockey", "IdJockey")
                        .IsRequired()
                        .HasConstraintName("FK_jockey_caballo");

                    b.Navigation("IdJockeyNavigation");
                });

            modelBuilder.Entity("ApuestasWebCaballos.Models.DataAcces.Caballo", b =>
                {
                    b.Navigation("Jockey");
                });
#pragma warning restore 612, 618
        }
    }
}