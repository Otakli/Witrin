using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class KategorilerMap : EntityTypeConfiguration<Kategoriler>
    {
        public KategorilerMap()
        {
            // Primary Key
            this.HasKey(t => t.kat_id);

            // Properties
            this.Property(t => t.kat_ad)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Kategoriler");
            this.Property(t => t.kat_id).HasColumnName("kat_id");
            this.Property(t => t.anakat_id).HasColumnName("anakat_id");
            this.Property(t => t.kat_ad).HasColumnName("kat_ad");
        }
    }
}
