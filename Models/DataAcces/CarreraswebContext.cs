using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApuestasWebCaballos.Models.DataAcces;

public partial class CarreraswebContext : DbContext
{
    public CarreraswebContext()
    {
    }

    public CarreraswebContext(DbContextOptions<CarreraswebContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Apuestum> Apuesta { get; set; }

    public virtual DbSet<Caballo> Caballos { get; set; }

    public virtual DbSet<Hipodromo> Hipodromos { get; set; }

    public virtual DbSet<Jockey> Jockeys { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Trabajador> Trabajadors { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user id=root;database=carrerasweb", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.27-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Apuestum>(entity =>
        {
            entity.HasKey(e => e.IdApuesta).HasName("PRIMARY");

            entity.ToTable("apuesta");

            entity.Property(e => e.IdApuesta)
                .HasColumnType("int(11) unsigned zerofill")
                .HasColumnName("id_apuesta");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
        });

        modelBuilder.Entity<Caballo>(entity =>
        {
            entity.HasKey(e => e.IdCaballo).HasName("PRIMARY");

            entity.ToTable("caballo");

            entity.Property(e => e.IdCaballo)
                .HasColumnType("int(11)")
                .HasColumnName("id_caballo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.Pigmentacion)
                .HasMaxLength(50)
                .HasColumnName("pigmentacion");
            entity.Property(e => e.Sexo)
                .HasMaxLength(50)
                .HasColumnName("sexo");
        });

        modelBuilder.Entity<Hipodromo>(entity =>
        {
            entity.HasKey(e => e.IdHipodromo).HasName("PRIMARY");

            entity.ToTable("hipodromo");

            entity.Property(e => e.IdHipodromo)
                .HasColumnType("int(11)")
                .HasColumnName("id_hipodromo");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .HasColumnName("direccion");
        });

        modelBuilder.Entity<Jockey>(entity =>
        {
            entity.HasKey(e => e.IdJockey).HasName("PRIMARY");

            entity.ToTable("jockey");

            entity.Property(e => e.IdJockey)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11)")
                .HasColumnName("id_jockey");
            entity.Property(e => e.ColorEquipo)
                .HasMaxLength(50)
                .HasColumnName("color_equipo");
            entity.Property(e => e.Copas)
                .HasColumnType("int(11)")
                .HasColumnName("copas");
            entity.Property(e => e.Numero)
                .HasColumnType("int(11)")
                .HasColumnName("numero");

            entity.HasOne(d => d.IdJockeyNavigation).WithOne(p => p.Jockey)
                .HasForeignKey<Jockey>(d => d.IdJockey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_jockey_caballo");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rol");

            entity.Property(e => e.IdRol)
                .HasColumnType("int(11)")
                .HasColumnName("id_rol");
            entity.Property(e => e.Rol1)
                .HasMaxLength(50)
                .HasColumnName("rol");
        });

        modelBuilder.Entity<Trabajador>(entity =>
        {
            entity.HasKey(e => e.IdTrabajador).HasName("PRIMARY");

            entity.ToTable("trabajador");

            entity.Property(e => e.IdTrabajador)
                .HasColumnType("int(11)")
                .HasColumnName("id_trabajador");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("apellido");
            entity.Property(e => e.CajaApuesta).HasColumnName("caja_apuesta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("usuario");

            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(50)
                .HasColumnName("contraseña");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .HasColumnName("correo");
            entity.Property(e => e.Dinero).HasColumnName("dinero");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
