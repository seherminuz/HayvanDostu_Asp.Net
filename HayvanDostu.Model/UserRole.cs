using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
  public class UserRole : BaseEntity
    {
        public UserRole()
        {
            Personals = new HashSet<Personal>();
            Corporates = new HashSet<Corporate>();
        }

        public string RoleName { get; set; }

        public virtual ICollection<Personal> Personals { get; set; }
        public virtual ICollection<Corporate> Corporates { get; set; }
    }
}
