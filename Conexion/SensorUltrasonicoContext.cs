﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API_SensorUltrasonico.Conexion
{
    public partial class SensorUltrasonicoContext : DbContext
    {
        public SensorUltrasonicoContext()
        {
        }

        public SensorUltrasonicoContext(DbContextOptions<SensorUltrasonicoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Registro> Registros { get; set; } = null!;
        public virtual DbSet<Sensor> Sensors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=localhost;DataBase=SensorUltrasonico;Trusted_Connection=True;");
                //conexión local para iis local usando usuario de sqlserver
                optionsBuilder.UseSqlServer("Server=localhost;DataBase=SensorUltrasonico;User ID=adminRestaurante123;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registro>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Registro");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mensaje).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sensor>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Sensor");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Sensor1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Sensor");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Sensors)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sensor_Registro");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
