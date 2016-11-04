using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class SipariMap : EntityTypeConfiguration<Sipari>
    {
        public SipariMap()
        {
            // Primary Key
            this.HasKey(t => t.siparis_id);

            // Properties
            this.Property(t => t.siparis_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.adres)
                .IsRequired();

            this.Property(t => t.kargo_kodu)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.sanalpos_sonuc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.fatura_ad)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.fatura_vergino)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Siparis");
            this.Property(t => t.siparis_id).HasColumnName("siparis_id");
            this.Property(t => t.uye_id).HasColumnName("uye_id");
            this.Property(t => t.tutar).HasColumnName("tutar");
            this.Property(t => t.adres).HasColumnName("adres");
            this.Property(t => t.kargo_id).HasColumnName("kargo_id");
            this.Property(t => t.kargo_kodu).HasColumnName("kargo_kodu");
            this.Property(t => t.banka_id).HasColumnName("banka_id");
            this.Property(t => t.sanalpos_sonuc).HasColumnName("sanalpos_sonuc");
            this.Property(t => t.odeme_id).HasColumnName("odeme_id");
            this.Property(t => t.siparis_tarih).HasColumnName("siparis_tarih");
            this.Property(t => t.fatura_ad).HasColumnName("fatura_ad");
            this.Property(t => t.fatura_vergino).HasColumnName("fatura_vergino");

            // Relationships
            this.HasRequired(t => t.Kargo)
                .WithMany(t => t.Siparis)
                .HasForeignKey(d => d.kargo_id);
            this.HasRequired(t => t.Odemesecenek)
                .WithMany(t => t.Siparis)
                .HasForeignKey(d => d.odeme_id);
            this.HasRequired(t => t.Uye)
                .WithMany(t => t.Siparis)
                .HasForeignKey(d => d.uye_id);

        }
    }
}
