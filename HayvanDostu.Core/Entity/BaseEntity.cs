using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Core.Entity
{
  public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            IsActive = true;
        }

        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
