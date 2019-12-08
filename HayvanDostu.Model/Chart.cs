using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Chart : BaseEntity
    {
        public DateTime ChartDate { get; set; }
        public DateTime ChartTime { get; set; }
        public bool IsFull { get; set; }
        public int CorporateID { get; set; }

        public virtual  Corporate Corporate{ get; set; }
    }
}
