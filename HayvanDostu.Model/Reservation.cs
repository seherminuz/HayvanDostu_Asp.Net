using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
   public class Reservation : BaseEntity
    {
        public DateTime ReservationDate { get; set; }
        public DateTime ReservationTıme { get; set; }
        public CareServiceType CareServiceType { get; set; }

        public int CorporateID { get; set; }

        public virtual Corporate Corporate { get; set; }

    }
}
