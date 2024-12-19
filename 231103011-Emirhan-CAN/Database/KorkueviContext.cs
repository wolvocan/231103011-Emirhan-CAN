using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _231103011_Emirhan_CAN.Database;

public partial class KorkueviContext : DbContext
{
    public KorkueviContext()
    {
    }

    public KorkueviContext(DbContextOptions<KorkueviContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Personel> Personels { get; set; }
    public virtual DbSet<Bilgiler> Bilgilers { get; set; }

    public virtual DbSet<Iletisim> Iletisims { get; set; }

    public virtual DbSet<Kurallar> Kurallars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-BSF6S52;Database=korkuevi;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bilgiler>(entity =>
        {
            entity.ToTable("Bilgiler");
        });
        modelBuilder.Entity<Personel>(entity =>
        {
            entity.ToTable("Personel");
        });

        modelBuilder.Entity<Iletisim>(entity =>
        {
            entity.ToTable("Iletisim");

            entity.Property(e => e.Telno)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Kurallar>(entity =>
        {
            entity.ToTable("Kurallar");

            entity.Property(e => e.Kurallar1).HasColumnName("Kurallar");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
