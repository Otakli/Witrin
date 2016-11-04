using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class ReklamResimlerMap : EntityTypeConfiguration<ReklamResimler>
    {
        public ReklamResimlerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.reklam_id, t.reklam_türü, t.reklam_yol });

            // Properties
            this.Property(t => t.reklam_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.reklam_türü)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.reklam_yol)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("ReklamResimler");
            this.Property(t => t.reklam_id).HasColumnName("reklam_id");
            this.Property(t => t.reklam_türü).HasColumnName("reklam_türü");
            this.Property(t => t.reklam_yol).HasColumnName("reklam_yol");
        }
    }
}
