using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Photo : BaseEntity
    {
        public Photo()
        {
           
        }

        public string PhotoPath { get; set; }

        public int CorporateID { get; set; }
        public int AccommodationID { get; set; }
        


        public virtual Pet Pet { get; set; }
        public virtual PersonalAccommodation PersonalAccommodation { get; set; }
        public virtual Corporate Corporate { get; set; }

    }
}
