using BussinesLayer.Abstract;
using DataLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class CvManager : IService<CvTablosu>
    {
        GenericRepository<CvTablosu> _cv = new GenericRepository<CvTablosu>();
        public void Add(CvTablosu entity)
        {
            _cv.Insert(entity);
        }

        public void Delete(CvTablosu entity)
        {
            _cv.Delete(entity);
        }

        public CvTablosu GetById(int id)
        {
            return _cv.Get(x => x.Id == id);
        }

        public List<CvTablosu> List()
        {
            return _cv.List();
        }

        public List<CvTablosu> List(Expression<Func<CvTablosu, bool>> filter)
        {
            return _cv.List();
        }

        public void Update(CvTablosu entity)
        {
            _cv.Update(entity);
        }
    }
}
