using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class UrunozelliktanımMap : EntityTypeConfiguration<Urunozelliktanım>
    {
        public UrunozelliktanımMap()
        {
            // Primary Key
            this.HasKey(t => t.ozellik_id);

            // Properties
            this.Property(t => t.ozellik_ad)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Urunozelliktanım");
            this.Property(t => t.ozellik_id).HasColumnName("ozellik_id");
            this.Property(t => t.ozellik_ad).HasColumnName("ozellik_ad");
        }
    }
}
