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
    public class CorporateService : ICorporateService
    {
        ICorporateDAL _CorporateDAL;

        public CorporateService(ICorporateDAL CorporateDAL)
        {
            _CorporateDAL = CorporateDAL;
        }

        public bool Delete(Corporate model)
        {
            return _CorporateDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Corporate Corporate = Get(entityID);
            return Delete(Corporate);
        }

        public Corporate Get(int entityID)
        {
            return _CorporateDAL.Get(a => a.ID == entityID);
        }

        public List<Corporate> GetAll()
        {
            return _CorporateDAL.GetAll().ToList();
        }

        public Corporate GetCorporateByLogin(string mail, string password)
        {
            return _CorporateDAL.Get(a => a.EMail == mail && a.Password == password && a.IsActive);
        }

        public bool Insert(Corporate model)
        {
            return _CorporateDAL.Add(model) > 0;
        }

        public bool Update(Corporate model)
        {
            return _CorporateDAL.Update(model) > 0;
        }
    }
}
