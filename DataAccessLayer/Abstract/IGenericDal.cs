using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// GENERICS... That will help to avoid to adjust the data access layers for each moment.
// Which means once I assign them here, It will generically apply to other DataAccessLayers... YEah... COOL!


namespace DataAccessLayer.Abstract
{

    public interface IGenericDal<T>
    {
        void Insert(T t);
        void Update(T t);   
        void Delete(T t);
        List<T> GetList();
    }
}
