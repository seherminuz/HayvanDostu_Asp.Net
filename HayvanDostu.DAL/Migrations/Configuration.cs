namespace HayvanDostu.DAL.Migrations
{
    using HayvanDostu.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HayvanDostu.DAL.Concrete.HayvanDostuDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(HayvanDostu.DAL.Concrete.HayvanDostuDBContext context)
        {
            List<UserRole> roles = new List<UserRole>();
            roles.Add(new UserRole() { RoleName = "Admin" });
            roles.Add(new UserRole() { RoleName = "Personal" });
            roles.Add(new UserRole() { RoleName = "Corporate" });
            context.UserRoles.AddRange(roles);
            context.SaveChanges();

            context.Personals.Add(new Personal()
            {
                Username = "shrmnz",
                FirstName = "Seher",
                LastName = "Minuz",
                Password = "1234",
                EMail = "seher@hotmail.com",
                BirthDate = new DateTime(1992, 5, 25),
                UserRole = roles[0]
            });
            context.SaveChanges();


            List<Personal> personals = new List<Personal>();
            personals.AddRange(new[]
            {

                new Personal { Username="sdnsyk", FirstName = "Þadan",LastName="Soyuk",EMail="sdnsyk@hotmail.com",Password="1234",BirthDate= new DateTime(1991,1,1),UserRole=roles[1],HaveAPet=true,PetCount=2},
                new Personal { Username="sfsmsk", FirstName = "Safa",LastName="Þimþek",EMail="sfsmsk@hotmail.com",Password="1234",BirthDate= new DateTime(1991,1,1),UserRole=roles[1],HaveAPet=false,PetCount=0},
                new Personal { Username="orkunsan", FirstName = "Orkun",LastName="Þanlý",EMail="orkunsnl@gmail.com",Password="1234",BirthDate= new DateTime(1991,1,1),UserRole=roles[1],HaveAPet=true,PetCount=3},
                new Personal { Username="akýnka", FirstName = "Akýn",LastName="Karabulut",EMail="akýnkarabulut@gmail.com",Password="1234",BirthDate= new DateTime(1989,6,26),UserRole=roles[1],HaveAPet=false,PetCount=0,IsActive=false},
                new Personal { Username="deryadok", FirstName = "Derya",LastName="Dok",EMail="deryadok@gmail.com",Password="1234",BirthDate= new DateTime(1995,1,1),UserRole=roles[1],HaveAPet=false,PetCount=0,IsActive=false},
                new Personal { Username="izzettineroglu", FirstName = "Ýzzettin",LastName="Eroðlu",EMail="izzettineroglu@gmail.com",Password="1234",BirthDate= new DateTime(1995,1,1),UserRole=roles[1],HaveAPet=true,PetCount=5,IsActive=false},
            });
            context.Personals.AddRange(personals);
            context.SaveChanges();

            List<Corporate> corporates = new List<Corporate>();
            corporates.AddRange(new[] {
                new Corporate { Username= "Pisagor",CompanyName= "Pisagor" , EMail= "pisagor@pisagor.com", Password ="1234" , CompanyType = CompanyType.Konaklama ,UserRole = roles[2]},
                 new Corporate { Username= "BilgeAdam",CompanyName= "BilgeAdam" , EMail= "bilgeadam@bilgeadam.com", Password ="1234" , CompanyType = CompanyType.Bakým, UserRole = roles[2],IsActive=false},
                   new Corporate { Username= "Oklid",CompanyName= "Oklid" , EMail= "oklid@oklid.com", Password ="1234" , CompanyType = CompanyType.Tedavi ,UserRole = roles[2],IsActive=false},
            });
            context.Corporates.AddRange(corporates);
            context.SaveChanges();

           
            //List<Pet> pets = new List<Pet>();
            //pets.AddRange(new[]
            //{
            //    new Pet{Name="Minnoþ",Story="Sokakta yaralý þekilde bulundu." , BirthDate= new DateTime(2019,1,1), PetKind = PetKind.Kedi , PetType="Sokak kedisi",Image="/Content/img/Tekir.JPG"},
            //     new Pet{Name="Karabaþ",Story="sahiplendirmeyi bekliyor." , BirthDate= new DateTime(2019,1,1), PetKind = PetKind.Köpek , PetType = "Sokak Köpeði",Image="/Content/img/Beagle.JPG"},
            //      new Pet{Name="Mini",Story="Sokakta yaralý þekilde bulundu." , BirthDate= new DateTime(2019,1,1), PetKind = PetKind.Kedi,PetType="Bilinmiyor.",Image="/Content/img/AnkaraKedisi.JPG"},
            //});
            //context.Pets.AddRange(pets);
            //context.SaveChanges();
        }
    }
}
