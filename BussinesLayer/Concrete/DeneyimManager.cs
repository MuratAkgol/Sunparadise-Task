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
    public class DeneyimManager : IService<Deneyim>
    {
        GenericRepository<Deneyim> _cv = new GenericRepository<Deneyim>();
        public void Add(Deneyim entity)
        {
            _cv.Insert(entity);
        }

        public void Delete(Deneyim entity)
        {
            _cv.Delete(entity);
        }

        public Deneyim GetById(int id)
        {
            return _cv.Get(x => x.Id == id);
        }

        public List<Deneyim> List()
        {
            return _cv.List();
        }

        public List<Deneyim> List(Expression<Func<Deneyim, bool>> filter)
        {
            return _cv.List();
        }

        public void Update(Deneyim entity)
        {
            _cv.Update(entity);
        }
    }
}
