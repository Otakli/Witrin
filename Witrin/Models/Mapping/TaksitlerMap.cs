using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class TaksitlerMap : EntityTypeConfiguration<Taksitler>
    {
        public TaksitlerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.banka_id, t.taksit, t.oran });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.banka_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.taksit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.oran)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Taksitler");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.banka_id).HasColumnName("banka_id");
            this.Property(t => t.taksit).HasColumnName("taksit");
            this.Property(t => t.oran).HasColumnName("oran");

            // Relationships
            this.HasRequired(t => t.Bankalar)
                .WithMany(t => t.Taksitlers)
                .HasForeignKey(d => d.banka_id);

        }
    }
}
