using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class SepetMap : EntityTypeConfiguration<Sepet>
    {
        public SepetMap()
        {
            // Primary Key
            this.HasKey(t => t.sepet_id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Sepet");
            this.Property(t => t.sepet_id).HasColumnName("sepet_id");
            this.Property(t => t.uye_id).HasColumnName("uye_id");
            this.Property(t => t.urun_id).HasColumnName("urun_id");
            this.Property(t => t.urun_fiyat).HasColumnName("urun_fiyat");
            this.Property(t => t.urun_adet).HasColumnName("urun_adet");
            this.Property(t => t.sepet_tarih).HasColumnName("sepet_tarih");

            // Relationships
            this.HasRequired(t => t.Urunler)
                .WithMany(t => t.Sepets)
                .HasForeignKey(d => d.urun_id);
            this.HasRequired(t => t.Uye)
                .WithMany(t => t.Sepets)
                .HasForeignKey(d => d.uye_id);

        }
    }
}
