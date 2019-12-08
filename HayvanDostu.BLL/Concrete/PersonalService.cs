using HayvanDostu.BLL.Abstract;
using HayvanDostu.DAL.Abstarct;
using HayvanDostu.DAL.Concrete.EntityFramework.DAL;
using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Concrete
{
    public class PersonalService : IPersonalService
    {
        IPersonalDAL _personalDAL;

        public PersonalService(IPersonalDAL PersonalDAL)
        {
            _personalDAL = PersonalDAL;
        }

        public bool Delete(Personal model)
        {
            return _personalDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Personal Personal = Get(entityID);
            return Delete(Personal);
        }

        public Personal Get(int entityID)
        {
            return _personalDAL.Get(a => a.ID == entityID);
        }

        public List<Personal> GetAll()
        {
            return _personalDAL.GetAll().ToList();
        }

      
      
        public Personal GetPersonalByLogin(string mail, string password)
        {
            return _personalDAL.Get(a => a.EMail == mail && a.Password == password && a.IsActive);
        }

        public Personal GetPersonalByReset(string mail, string username)
        {
            return _personalDAL.Get(a => a.EMail == mail && a.Username == username);
        }

        public bool Insert(Personal model)
        {
            return _personalDAL.Add(model) > 0;
        }

        public bool Update(Personal model)
        {
            return _personalDAL.Update(model) > 0;
        }
    }
}
