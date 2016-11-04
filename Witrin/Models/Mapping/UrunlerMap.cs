using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class UrunlerMap : EntityTypeConfiguration<Urunler>
    {
        public UrunlerMap()
        {
            // Primary Key
            this.HasKey(t => t.urun_id);

            // Properties
            this.Property(t => t.urun_ad)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Urunler");
            this.Property(t => t.urun_id).HasColumnName("urun_id");
            this.Property(t => t.urun_ad).HasColumnName("urun_ad");
            this.Property(t => t.kat_id).HasColumnName("kat_id");
            this.Property(t => t.marka_id).HasColumnName("marka_id");
            this.Property(t => t.urunresim_id).HasColumnName("urunresim_id");
            this.Property(t => t.urun_fiyat).HasColumnName("urun_fiyat");
            this.Property(t => t.stokadet).HasColumnName("stokadet");

            // Relationships
            this.HasRequired(t => t.Kategoriler)
                .WithMany(t => t.Urunlers)
                .HasForeignKey(d => d.kat_id);
            this.HasRequired(t => t.Markalar)
                .WithMany(t => t.Urunlers)
                .HasForeignKey(d => d.marka_id);
            this.HasRequired(t => t.Urunresimler)
                .WithMany(t => t.Urunlers)
                .HasForeignKey(d => d.urunresim_id);

        }
    }
}
