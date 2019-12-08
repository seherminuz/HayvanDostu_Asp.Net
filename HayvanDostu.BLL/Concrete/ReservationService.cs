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
   public class ReservationService : IReservationService
    {
        IReservationDAL _reservationDAL;
        public ReservationService(IReservationDAL reservationDAL)
        {
            _reservationDAL = reservationDAL;
        }

      

        public bool Delete(Reservation model)
        {
            return _reservationDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Reservation reservation = Get(entityID);
            return Delete(reservation);
        }

        public Reservation Get(int entityID)
        {
            return _reservationDAL.Get(a => a.ID == entityID);
        }

        public List<Reservation> GetAll()
        {
            return _reservationDAL.GetAll().ToList();
        }

        public bool Insert(Reservation model)
        {
            return _reservationDAL.Add(model) > 0;
        }

        public bool Update(Reservation model)
        {
            return _reservationDAL.Update(model) > 0;
        }
    }
}
