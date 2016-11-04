using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class KargoMap : EntityTypeConfiguration<Kargo>
    {
        public KargoMap()
        {
            // Primary Key
            this.HasKey(t => t.Kargo_id);

            // Properties
            this.Property(t => t.Kargo_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Firma_ad)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Kargo");
            this.Property(t => t.Kargo_id).HasColumnName("Kargo_id");
            this.Property(t => t.Firma_ad).HasColumnName("Firma_ad");
        }
    }
}
