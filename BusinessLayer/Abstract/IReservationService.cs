using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericServices<Reservation>
    {
        List<Reservation> GetListWithReservationPending(int id);
        List<Reservation> GetListWithReservationPrevious(int id);
        List<Reservation> GetListWithReservationAccepted(int id);

    }
}
