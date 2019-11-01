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
    public class VeterinaryService : IVeterinaryService
    {
        IVeterinaryDAL _VeterinaryDAL;

        public VeterinaryService(IVeterinaryDAL VeterinaryDAL)
        {
            _VeterinaryDAL = VeterinaryDAL;
        }

        public bool Delete(Veterinary model)
        {
            return _VeterinaryDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Veterinary Veterinary = Get(entityID);
            return Delete(Veterinary);
        }

        public Veterinary Get(int entityID)
        {
            return _VeterinaryDAL.Get(a => a.ID == entityID);
        }

        public List<Veterinary> GetAll()
        {
            return _VeterinaryDAL.GetAll().ToList();
        }


        public bool Insert(Veterinary model)
        {
            return _VeterinaryDAL.Add(model) > 0;
        }

        public bool Update(Veterinary model)
        {
            return _VeterinaryDAL.Update(model) > 0;
        }
    }
}
