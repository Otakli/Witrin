using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class UrunozellikMap : EntityTypeConfiguration<Urunozellik>
    {
        public UrunozellikMap()
        {
            // Primary Key
            this.HasKey(t => t.ozellikdetay_id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Urunozellik");
            this.Property(t => t.ozellikdetay_id).HasColumnName("ozellikdetay_id");
            this.Property(t => t.ozellik_id).HasColumnName("ozellik_id");
            this.Property(t => t.urun_id).HasColumnName("urun_id");
            this.Property(t => t.deger).HasColumnName("deger");

            // Relationships
            this.HasOptional(t => t.Urunler)
                .WithMany(t => t.Urunozelliks)
                .HasForeignKey(d => d.urun_id);
            this.HasOptional(t => t.Urunozelliktanım)
                .WithMany(t => t.Urunozelliks)
                .HasForeignKey(d => d.ozellik_id);

        }
    }
}
