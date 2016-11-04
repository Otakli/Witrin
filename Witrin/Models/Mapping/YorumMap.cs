using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class YorumMap : EntityTypeConfiguration<Yorum>
    {
        public YorumMap()
        {
            // Primary Key
            this.HasKey(t => t.Yorum_id);

            // Properties
            this.Property(t => t.Yorum_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.icerik)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Yorum");
            this.Property(t => t.Yorum_id).HasColumnName("Yorum_id");
            this.Property(t => t.Urun_id).HasColumnName("Urun_id");
            this.Property(t => t.icerik).HasColumnName("icerik");
            this.Property(t => t.eklenme_tarih).HasColumnName("eklenme_tarih");

            // Relationships
            this.HasRequired(t => t.Urunler)
                .WithMany(t => t.Yorums)
                .HasForeignKey(d => d.Urun_id);

        }
    }
}
