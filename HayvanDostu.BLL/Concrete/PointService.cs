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
    public class PointService : IPointService
    {
        IPointDAL _PointDAL;

        public PointService(IPointDAL PointDAL)
        {
            _PointDAL = PointDAL;
        }

        public bool Delete(Point model)
        {
            return _PointDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Point Point = Get(entityID);
            return Delete(Point);
        }

        public Point Get(int entityID)
        {
            return _PointDAL.Get(a => a.ID == entityID);
        }

        public List<Point> GetAll()
        {
            return _PointDAL.GetAll().ToList();
        }


        public bool Insert(Point model)
        {
            return _PointDAL.Add(model) > 0;
        }

        public bool Update(Point model)
        {
            return _PointDAL.Update(model) > 0;
        }
    }
}
