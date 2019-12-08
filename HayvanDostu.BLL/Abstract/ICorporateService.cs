using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Abstract
{
   public interface ICorporateService : IBaseService<Corporate>
    {
        Corporate GetCorporateByLogin(string mail, string password);
    }
}
