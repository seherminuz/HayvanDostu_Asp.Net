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
    public class ChartService : IChartService
    {
        IChartDAL _chartDAL;
        public ChartService(IChartDAL chartDAL)
        {
            _chartDAL = chartDAL;
        }
        public bool Delete(Chart model)
        {
            return _chartDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Chart chart = Get(entityID);
            return Delete(chart);
        }

        public Chart Get(int entityID)
        {
            return _chartDAL.Get(a => a.ID == entityID);
        }

        public List<Chart> GetAll()
        {
            return _chartDAL.GetAll().ToList();
        }

        public bool Insert(Chart model)
        {
            return _chartDAL.Add(model) > 0;
        }

        public bool Update(Chart model)
        {
            return _chartDAL.Update(model) > 0;

        }
    }
}
