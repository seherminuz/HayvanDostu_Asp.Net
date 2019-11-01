using HayvanDostu.BLL.Abstract;
using HayvanDostu.DAL.Abstarct;
using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Concrete
{
    public class PriceService : IPriceService
    {
        IPriceDAL _priceDAL;
        public PriceService(IPriceDAL priceDAL)
        {
            _priceDAL = priceDAL;
        }
        public bool Delete(Price model)
        {
            return _priceDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Price price = Get(entityID);
            return Delete(price);
        }

        public Price Get(int entityID)
        {
            return _priceDAL.Get(a => a.ID == entityID);
        }

        public List<Price> GetAll()
        {
            return _priceDAL.GetAll().ToList();
        }

        public bool Insert(Price model)
        {
            return _priceDAL.Add(model) > 0;
        }

        public bool Update(Price model)
        {
            return _priceDAL.Update(model) > 0;
        }
    }
}
