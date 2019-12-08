using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class MainPageOptions : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Keywords { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string SocialLink1 { get; set; }
        public string SocialLink2 { get; set; }
        public string SocialLink3 { get; set; }
    }
}
