using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class KampanyalarMap : EntityTypeConfiguration<Kampanyalar>
    {
        public KampanyalarMap()
        {
            // Primary Key
            this.HasKey(t => t.Kampanya_id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Kampanyalar");
            this.Property(t => t.Kampanya_id).HasColumnName("Kampanya_id");
            this.Property(t => t.Urun_id).HasColumnName("Urun_id");
            this.Property(t => t.indirimoran).HasColumnName("indirimoran");

            // Relationships
            this.HasRequired(t => t.Urunler)
                .WithMany(t => t.Kampanyalars)
                .HasForeignKey(d => d.Urun_id);

        }
    }
}
