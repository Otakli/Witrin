using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class BankalarMap : EntityTypeConfiguration<Bankalar>
    {
        public BankalarMap()
        {
            // Primary Key
            this.HasKey(t => t.banka_id);

            // Properties
            this.Property(t => t.banka_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.banka_ad)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Bankalar");
            this.Property(t => t.banka_id).HasColumnName("banka_id");
            this.Property(t => t.banka_ad).HasColumnName("banka_ad");
        }
    }
}
