using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {

        //Dependency Injection
        IReservationDal _reservationDal;



        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }
        //The constructor method

        public Reservation GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationAccepted(int id)
        {
            return _reservationDal.GetListWithtReservationAccepted(id);
        }

        public List<Reservation> GetListWithReservationPending(int id)
        {
            return _reservationDal.GetListWithReservationPending(id);


        }

        public List<Reservation> GetListWithReservationPrevious(int id)
        {
            return _reservationDal.GetListWithtReservationPrevious(id);
        }

        public void TAdd(Reservation t) 
        {
            _reservationDal.Insert(t);

        }

        public void TDelete(Reservation t)
        {
            _reservationDal.Delete(t);

        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();

        }

        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);


        }
    }
}

