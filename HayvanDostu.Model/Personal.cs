using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Personal : BaseUserEntity
    {
        public Personal()
        {
            
            Points = new HashSet<Point>();
            Comments = new HashSet<Comment>();
            Pets = new HashSet<Pet>();
            PersonalAccommodations = new HashSet<PersonalAccommodation>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public bool HaveAPet { get; set; }
        public int PetCount { get; set; }
        public int UserRoleID { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Point> Points { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
        public virtual ICollection<PersonalAccommodation> PersonalAccommodations { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
