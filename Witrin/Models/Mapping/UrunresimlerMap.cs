using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class UrunresimlerMap : EntityTypeConfiguration<Urunresimler>
    {
        public UrunresimlerMap()
        {
            // Primary Key
            this.HasKey(t => t.urunresim_id);

            // Properties
            this.Property(t => t.urunresim_ad)
                .IsRequired();

            this.Property(t => t.kucukresim)
                .IsRequired();

            this.Property(t => t.ortaresim)
                .IsRequired();

            this.Property(t => t.buyukresim)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Urunresimler");
            this.Property(t => t.urunresim_id).HasColumnName("urunresim_id");
            this.Property(t => t.urunresim_ad).HasColumnName("urunresim_ad");
            this.Property(t => t.kucukresim).HasColumnName("kucukresim");
            this.Property(t => t.ortaresim).HasColumnName("ortaresim");
            this.Property(t => t.buyukresim).HasColumnName("buyukresim");
        }
    }
}
