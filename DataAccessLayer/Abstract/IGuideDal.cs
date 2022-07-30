using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{ 
    //For CRUD processes sake, I will assign some methods for deleting, updating, add and so on.
  
    public interface IGuideDal
    {
        void Insert(Guide guide);
        void Update(Guide guide);
        void Delete(Guide guide);
        List<Guide> GetList();


    }

}
