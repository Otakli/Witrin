using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class UrunSatiMap : EntityTypeConfiguration<UrunSati>
    {
        public UrunSatiMap()
        {
            // Primary Key
            this.HasKey(t => t.urunsatis_id);

            // Properties
            // Table & Column Mappings
            this.ToTable("UrunSatis");
            this.Property(t => t.urunsatis_id).HasColumnName("urunsatis_id");
            this.Property(t => t.urun_id).HasColumnName("urun_id");
            this.Property(t => t.satis_adet).HasColumnName("satis_adet");
            this.Property(t => t.satis_date).HasColumnName("satis_date");
            this.Property(t => t.uye_id).HasColumnName("uye_id");

            // Relationships
            this.HasRequired(t => t.Urunler)
                .WithMany(t => t.UrunSatis)
                .HasForeignKey(d => d.urun_id);
            this.HasRequired(t => t.Uye)
                .WithMany(t => t.UrunSatis)
                .HasForeignKey(d => d.uye_id);

        }
    }
}
