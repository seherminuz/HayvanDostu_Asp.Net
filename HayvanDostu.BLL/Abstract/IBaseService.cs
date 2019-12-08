using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Abstract
{
   public interface IBaseService<T>
        where T : BaseEntity
    {
        bool Insert(T model);
        bool Delete(T model);
        bool DeleteByID(int entityID);
        bool Update(T model);
        T Get(int entityID);
        List<T> GetAll();
    }
}
