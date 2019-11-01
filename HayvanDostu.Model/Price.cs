using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
   public class Price : BaseEntity
    {
        public Price()
        {
            ReservationAccommodations = new HashSet<ReservationAccommodation>();

        }
        
        public string CartNo { get; set; }
        public string SecurityCode { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CardOwner { get; set; }
        public string PaymentMethod { get; set; }

        public virtual ICollection<ReservationAccommodation> ReservationAccommodations { get; set; }
        
    }
}
