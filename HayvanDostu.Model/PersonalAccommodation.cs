using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class PersonalAccommodation : BaseEntity
    {
        public PersonalAccommodation()
        {
            Photo = new HashSet<Photo>();
        }

        public string Job { get; set; }
        public string CarePets { get; set; }
        public bool HavePets { get; set; }
        public decimal Price { get; set; }

        public int PersonalID { get; set; }

        public virtual Personal Personal { get; set; }
        public virtual ICollection<Photo> Photo { get; set; }

    }
}
