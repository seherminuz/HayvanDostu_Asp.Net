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
    public class PhotoService : IPhotoService
    {
        IPhotoDAL _PhotoDAL;

        public PhotoService(IPhotoDAL PhotoDAL)
        {
            _PhotoDAL = PhotoDAL;
        }

        public bool Delete(Photo model)
        {
            return _PhotoDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Photo Photo = Get(entityID);
            return Delete(Photo);
        }

        public Photo Get(int entityID)
        {
            return _PhotoDAL.Get(a => a.ID == entityID);
        }

        public List<Photo> GetAll()
        {
            return _PhotoDAL.GetAll().ToList();
        }


        public bool Insert(Photo model)
        {
            return _PhotoDAL.Add(model) > 0;
        }

        public bool Update(Photo model)
        {
            return _PhotoDAL.Update(model) > 0;
        }
    }
}
