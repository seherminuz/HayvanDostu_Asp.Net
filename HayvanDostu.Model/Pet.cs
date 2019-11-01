using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Pet : BaseEntity
    {
        public Pet()
        {
            Photos = new HashSet<Photo>();
            ReservationAccommodations = new HashSet<ReservationAccommodation>();
        }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public string Story { get; set; }
        public string Image { get; set; }
        public PetKind PetKind { get; set; }
        public string PetType { get; set; }
        public string Contact { get; set; }



        public int IndividualID { get; set; }

        
        public virtual ICollection<Photo> Photos { get; set; }

        public virtual Personal Personal { get; set; }
        public virtual ICollection<ReservationAccommodation> ReservationAccommodations { get; set; }


    }
}
