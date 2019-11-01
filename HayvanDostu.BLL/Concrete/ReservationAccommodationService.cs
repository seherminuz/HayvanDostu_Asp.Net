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
    public class ReservationAccommodationService : IReservationAccommodationService
    {
        IReservationAccommodationDAL _reservationAccommodationDAL;
        public ReservationAccommodationService(IReservationAccommodationDAL reservationAccommodationDAL)
        {
            _reservationAccommodationDAL = reservationAccommodationDAL;
        }

      
        public bool Delete(ReservationAccommodation model)
        {
            return _reservationAccommodationDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            ReservationAccommodation reservationAccommodation = Get(entityID);
            return Delete(reservationAccommodation);

           
        }

        public ReservationAccommodation Get(int entityID)
        {
            return _reservationAccommodationDAL.Get(a => a.ID == entityID);
        }

        public List<ReservationAccommodation> GetAll()
        {
            return _reservationAccommodationDAL.GetAll().ToList();
        }

        public bool Insert(ReservationAccommodation model)
        {
            return _reservationAccommodationDAL.Add(model) > 0;
        }

        public bool Update(ReservationAccommodation model)
        {
            return _reservationAccommodationDAL.Update(model) > 0;
        }
    }
}
