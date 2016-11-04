using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class OdemesecenekMap : EntityTypeConfiguration<Odemesecenek>
    {
        public OdemesecenekMap()
        {
            // Primary Key
            this.HasKey(t => t.odeme_id);

            // Properties
            this.Property(t => t.odeme_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.odeme_tip)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Odemesecenek");
            this.Property(t => t.odeme_id).HasColumnName("odeme_id");
            this.Property(t => t.odeme_tip).HasColumnName("odeme_tip");
        }
    }
}
