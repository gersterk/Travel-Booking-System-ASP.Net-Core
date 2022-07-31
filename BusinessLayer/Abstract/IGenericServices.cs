using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stores the signatures of business methods in Concrete Classes

namespace BusinessLayer.Abstract
{
    public interface IGenericServices<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);

        List<T> TGetList(); // It should be List because it must return something
        T GetByID(int id);
    }
}
