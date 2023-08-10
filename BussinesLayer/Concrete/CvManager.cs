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
    public class CvManager : IService<CvTable>
    {
        GenericRepository<CvTable> _cv = new GenericRepository<CvTable>();
        public void Add(CvTable entity)
        {
            _cv.Insert(entity);
        }

        public void Delete(CvTable entity)
        {
            _cv.Delete(entity);
        }

        public CvTable GetById(int id)
        {
            return _cv.Get(x => x.Id == id);
        }

        public List<CvTable> List()
        {
            return _cv.List();
        }

        public List<CvTable> List(Expression<Func<CvTable, bool>> filter)
        {
            return _cv.List();
        }

        public void Update(CvTable entity)
        {
            _cv.Update(entity);
        }
    }
}
