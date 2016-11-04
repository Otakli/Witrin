using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class SehirlerMap : EntityTypeConfiguration<Sehirler>
    {
        public SehirlerMap()
        {
            // Primary Key
            this.HasKey(t => t.sehir_id);

            // Properties
            this.Property(t => t.sehir_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sehir_ad)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("Sehirler");
            this.Property(t => t.sehir_id).HasColumnName("sehir_id");
            this.Property(t => t.sehir_ad).HasColumnName("sehir_ad");
        }
    }
}
