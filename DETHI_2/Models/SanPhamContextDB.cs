using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DETHI_2.Models
{
  public partial class SanPhamContextDB : DbContext
  {
    public SanPhamContextDB()
        : base("name=SanPhamContextDB")
    {
    }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<LoaiSanPham>()
          .Property(e => e.MaLoai)
          .IsFixedLength()
          .IsUnicode(false);

      modelBuilder.Entity<LoaiSanPham>()
          .HasMany(e => e.SanPhams)
          .WithRequired(e => e.LoaiSanPham)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<SanPham>()
          .Property(e => e.MaSanPham)
          .IsFixedLength()
          .IsUnicode(false);

      modelBuilder.Entity<SanPham>()
          .Property(e => e.MaLoai)
          .IsFixedLength()
          .IsUnicode(false);
    }
  }
}
