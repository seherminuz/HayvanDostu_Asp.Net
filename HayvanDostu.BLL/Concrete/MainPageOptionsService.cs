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
   public class MainPageOptionsService : IMainPageOptionsService
    {
        IMainPageOptionsDAL _mainPageOptionsDAL;
        public MainPageOptionsService(IMainPageOptionsDAL mainPageOptionsDAL)
        {
            _mainPageOptionsDAL = mainPageOptionsDAL;
        }
        public bool Delete(MainPageOptions model)
        {
            return _mainPageOptionsDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            MainPageOptions mainPageOptions = Get(entityID);
            return Delete(mainPageOptions);
        }

        public MainPageOptions Get(int entityID)
        {
            return _mainPageOptionsDAL.Get(a => a.ID == entityID);
        }

        public List<MainPageOptions> GetAll()
        {
            return _mainPageOptionsDAL.GetAll().ToList();
        }

        public bool Insert(MainPageOptions model)
        {
            return _mainPageOptionsDAL.Add(model) > 0;
        }

        public bool Update(MainPageOptions model)
        {
            return _mainPageOptionsDAL.Update(model) > 0;

        }
    }
}
