using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Witrin.Models.Mapping;

namespace Witrin.Models
{
    public partial class witrinContext : DbContext
    {
        static witrinContext()
        {
            Database.SetInitializer<witrinContext>(null);
        }

        public witrinContext()
            : base("Name=witrinContext")
        {
        }

        public DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public DbSet<aspnet_Users> aspnet_Users { get; set; }
        public DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public DbSet<Bankalar> Bankalars { get; set; }
        public DbSet<Kampanyalar> Kampanyalars { get; set; }
        public DbSet<Kargo> Kargoes { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Markalar> Markalars { get; set; }
        public DbSet<Odemesecenek> Odemeseceneks { get; set; }
        public DbSet<ReklamResimler> ReklamResimlers { get; set; }
        public DbSet<Sehirler> Sehirlers { get; set; }
        public DbSet<Sepet> Sepets { get; set; }
        public DbSet<Sipari> Siparis { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Taksitler> Taksitlers { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Urunozellik> Urunozelliks { get; set; }
        public DbSet<Urunozelliktanım> Urunozelliktanım { get; set; }
        public DbSet<Urunresimler> Urunresimlers { get; set; }
        public DbSet<UrunSati> UrunSatis { get; set; }
        public DbSet<Uye> Uyes { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
        public DbSet<vw_aspnet_Applications> vw_aspnet_Applications { get; set; }
        public DbSet<vw_aspnet_MembershipUsers> vw_aspnet_MembershipUsers { get; set; }
        public DbSet<vw_aspnet_Profiles> vw_aspnet_Profiles { get; set; }
        public DbSet<vw_aspnet_Roles> vw_aspnet_Roles { get; set; }
        public DbSet<vw_aspnet_Users> vw_aspnet_Users { get; set; }
        public DbSet<vw_aspnet_UsersInRoles> vw_aspnet_UsersInRoles { get; set; }
        public DbSet<vw_aspnet_WebPartState_Paths> vw_aspnet_WebPartState_Paths { get; set; }
        public DbSet<vw_aspnet_WebPartState_Shared> vw_aspnet_WebPartState_Shared { get; set; }
        public DbSet<vw_aspnet_WebPartState_User> vw_aspnet_WebPartState_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new aspnet_ApplicationsMap());
            modelBuilder.Configurations.Add(new aspnet_MembershipMap());
            modelBuilder.Configurations.Add(new aspnet_PathsMap());
            modelBuilder.Configurations.Add(new aspnet_PersonalizationAllUsersMap());
            modelBuilder.Configurations.Add(new aspnet_PersonalizationPerUserMap());
            modelBuilder.Configurations.Add(new aspnet_ProfileMap());
            modelBuilder.Configurations.Add(new aspnet_RolesMap());
            modelBuilder.Configurations.Add(new aspnet_SchemaVersionsMap());
            modelBuilder.Configurations.Add(new aspnet_UsersMap());
            modelBuilder.Configurations.Add(new aspnet_WebEvent_EventsMap());
            modelBuilder.Configurations.Add(new BankalarMap());
            modelBuilder.Configurations.Add(new KampanyalarMap());
            modelBuilder.Configurations.Add(new KargoMap());
            modelBuilder.Configurations.Add(new KategorilerMap());
            modelBuilder.Configurations.Add(new MarkalarMap());
            modelBuilder.Configurations.Add(new OdemesecenekMap());
            modelBuilder.Configurations.Add(new ReklamResimlerMap());
            modelBuilder.Configurations.Add(new SehirlerMap());
            modelBuilder.Configurations.Add(new SepetMap());
            modelBuilder.Configurations.Add(new SipariMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TaksitlerMap());
            modelBuilder.Configurations.Add(new UrunlerMap());
            modelBuilder.Configurations.Add(new UrunozellikMap());
            modelBuilder.Configurations.Add(new UrunozelliktanımMap());
            modelBuilder.Configurations.Add(new UrunresimlerMap());
            modelBuilder.Configurations.Add(new UrunSatiMap());
            modelBuilder.Configurations.Add(new UyeMap());
            modelBuilder.Configurations.Add(new YorumMap());
            modelBuilder.Configurations.Add(new vw_aspnet_ApplicationsMap());
            modelBuilder.Configurations.Add(new vw_aspnet_MembershipUsersMap());
            modelBuilder.Configurations.Add(new vw_aspnet_ProfilesMap());
            modelBuilder.Configurations.Add(new vw_aspnet_RolesMap());
            modelBuilder.Configurations.Add(new vw_aspnet_UsersMap());
            modelBuilder.Configurations.Add(new vw_aspnet_UsersInRolesMap());
            modelBuilder.Configurations.Add(new vw_aspnet_WebPartState_PathsMap());
            modelBuilder.Configurations.Add(new vw_aspnet_WebPartState_SharedMap());
            modelBuilder.Configurations.Add(new vw_aspnet_WebPartState_UserMap());
        }
    }
}
