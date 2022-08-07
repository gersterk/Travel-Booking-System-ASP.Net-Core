using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        //Dependency Injection
        IAboutDal _aboutDal;     


       
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        //public List<About> GetByFilter(Expression<Func<About, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //The constructor method

        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);

        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);

        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();

        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);

                
        }
    }
}
