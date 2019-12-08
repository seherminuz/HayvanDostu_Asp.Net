using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
   public class ReservationAccommodation : BaseEntity
    {
      
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int  Piece { get; set; }
        public ServiceType  AccommodationServiceType { get; set; }

        public int PetID { get; set; }
        public int CorporateID { get; set; }
        public int PriceID { get; set; }

        public virtual Price Price { get; set; }
        public virtual Pet Pet { get; set; }
        public virtual Corporate Corporate { get; set; }


    }
}
