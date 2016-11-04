using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Witrin.Models.Mapping
{
    public class UyeMap : EntityTypeConfiguration<Uye>
    {
        public UyeMap()
        {
            // Primary Key
            this.HasKey(t => t.uye_id);

            // Properties
            this.Property(t => t.uye_ad)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.uye_soyad)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.mail)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.cep_tel)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Uye");
            this.Property(t => t.uye_id).HasColumnName("uye_id");
            this.Property(t => t.uye_ad).HasColumnName("uye_ad");
            this.Property(t => t.uye_soyad).HasColumnName("uye_soyad");
            this.Property(t => t.mail).HasColumnName("mail");
            this.Property(t => t.kayıt_tarih).HasColumnName("kayıt_tarih");
            this.Property(t => t.sehir_id).HasColumnName("sehir_id");
            this.Property(t => t.cep_tel).HasColumnName("cep_tel");
            this.Property(t => t.kullanıcı_tip).HasColumnName("kullanıcı_tip");

            // Relationships
            this.HasRequired(t => t.aspnet_Users)
                .WithOptional(t => t.Uye);
            this.HasRequired(t => t.Sehirler)
                .WithMany(t => t.Uyes)
                .HasForeignKey(d => d.sehir_id);

        }
    }
}
