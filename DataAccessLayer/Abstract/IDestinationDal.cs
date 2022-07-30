using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDestinationDal
    {
        void Inser(Destination destination);
        void Delete(Destination destination);
        void Update(Destination destination);

        List<IDestinationDal> GetList();


    }
}
