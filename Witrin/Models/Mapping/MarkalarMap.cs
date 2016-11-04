using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class MarkalarMap : EntityTypeConfiguration<Markalar>
    {
        public MarkalarMap()
        {
            // Primary Key
            this.HasKey(t => t.marka_id);

            // Properties
            this.Property(t => t.marka_ad)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Markalar");
            this.Property(t => t.marka_id).HasColumnName("marka_id");
            this.Property(t => t.marka_ad).HasColumnName("marka_ad");
        }
    }
}
