using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
   public class Corporate : BaseUserEntity
    {
        public Corporate()
        {
            ReservationAccommodations = new HashSet<ReservationAccommodation>();
            Reservations = new HashSet<Reservation>();
            Points = new HashSet<Point>();
            Photo = new HashSet<Photo>();

            Comments = new HashSet<Comment>();
            Veterinaries = new HashSet<Veterinary>();
            Charts = new HashSet<Chart>();
        }
        public string CompanyName { get; set; }
       
        public int UserRoleID { get; set; }

        public CompanyType CompanyType { get; set; }

        public virtual ICollection<ReservationAccommodation> ReservationAccommodations { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Point> Points { get; set; }
        public virtual ICollection<Photo> Photo { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Veterinary> Veterinaries { get; set; }
        public virtual ICollection<Chart> Charts { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
    
}
