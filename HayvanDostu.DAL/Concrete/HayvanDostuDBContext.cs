using HayvanDostu.DAL.Concrete.EntityFramework.Mappings;
using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Concrete
{
    public class HayvanDostuDBContext : DbContext

    {
        public HayvanDostuDBContext()
             : base(@"Server =USER-TOSH\SEHERSQL; Database = HayvanDostuDB; Trusted_Connection=True")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PetMapping());
            modelBuilder.Configurations.Add(new PhotoMapping());
            modelBuilder.Configurations.Add(new MessageMapping());
            modelBuilder.Configurations.Add(new ChartMapping());
            modelBuilder.Configurations.Add(new PriceMapping());         
            modelBuilder.Configurations.Add(new PersonalMapping());
            modelBuilder.Configurations.Add(new CorporateMapping());
            modelBuilder.Configurations.Add(new CommentMapping());
            modelBuilder.Configurations.Add(new PersonalAccommodationMapping());
            modelBuilder.Configurations.Add(new ReservationAccommodationMapping());
            modelBuilder.Configurations.Add(new MainPageOptionsMapping());



            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           

            //modelBuilder.Properties()
            //    .Where(a => a.PropertyType == typeof(string))
            //    .Configure(a => a.IsRequired());
        }
        public DbSet<ReservationAccommodation> ReservationAccommodations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Chart> Charts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<PersonalAccommodation> PersonalAccommodations { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Veterinary> Veterinaries { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Corporate> Corporates { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MainPageOptions> MainPageOptions { get; set; }










    }


}
