using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Veterinary : BaseEntity
    {
        public Veterinary()
        {
            Comments = new HashSet<Comment>();
            Points = new HashSet<Point>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string ImagePath { get; set; }
        public DateTime GraduationYear { get; set; }
        public string GraduationUniversity { get; set; }
        public string Experience { get; set; }
        public int CorporateID { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Corporate Corporate { get; set; }
        public virtual ICollection<Point> Points { get; set; }


    }
}
