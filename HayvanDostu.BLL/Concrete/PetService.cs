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
    public class PetService : IPetService
    {
        IPetDAL _petDAL;
        public PetService(IPetDAL PetDAL)
        {
            _petDAL = PetDAL;
        }
        public bool Delete(Pet model)
        {
            return _petDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Pet Pet = Get(entityID);
            return Delete(Pet);
        }

        public Pet Get(int entityID)
        {
            return _petDAL.Get(a => a.ID == entityID);
        }

        public List<Pet> GetAll()
        {
            return _petDAL.GetAll().ToList();
        }

        public bool Insert(Pet model)
        {
            return _petDAL.Add(model) > 0;
        }

        public bool Update(Pet model)
        {
            return _petDAL.Update(model) > 0;
        }
    }
}
