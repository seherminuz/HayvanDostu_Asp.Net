using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Abstract
{
    public interface IPersonalService : IBaseService<Personal>
    {
        Personal GetPersonalByLogin(string mail, string password);
        Personal GetPersonalByReset(string mail, string username);
       

    }
}
