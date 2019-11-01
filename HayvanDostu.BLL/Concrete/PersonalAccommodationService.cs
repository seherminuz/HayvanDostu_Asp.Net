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
    public class PersonalAccommodationService : IPersonalAccommodationService
    {
        IPersonalAccommodationDAL _personalAccommodation;
        public PersonalAccommodationService(IPersonalAccommodationDAL personalAccommodationDAL)
        {
            _personalAccommodation = personalAccommodationDAL;
        }
        public bool Delete(PersonalAccommodation model)
        {
            return _personalAccommodation.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            PersonalAccommodation personalAccommodation = Get(entityID);
            return Delete(personalAccommodation);
        }

        public PersonalAccommodation Get(int entityID)
        {
            return _personalAccommodation.Get(a => a.ID == entityID);
        }

        public List<PersonalAccommodation> GetAll()
        {
            return _personalAccommodation.GetAll().ToList();
        }

        public bool Insert(PersonalAccommodation model)
        {
            return _personalAccommodation.Add(model) > 0;
        }

        public bool Update(PersonalAccommodation model)
        {
            return _personalAccommodation.Update(model) > 0;
        }
    }
}
