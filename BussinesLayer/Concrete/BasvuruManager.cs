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
    public class BasvuruManager : IService<Basvuru>
    {
        GenericRepository<Basvuru> _cv = new GenericRepository<Basvuru>();
        public void Add(Basvuru entity)
        {
            _cv.Insert(entity);
        }

        public void Delete(Basvuru entity)
        {
            _cv.Delete(entity);
        }

        public Basvuru GetById(int id)
        {
            return _cv.Get(x => x.Id == id);
        }

        public List<Basvuru> List()
        {
            return _cv.List();
        }

        public List<Basvuru> List(Expression<Func<Basvuru, bool>> filter)
        {
            return _cv.List();
        }

        public void Update(Basvuru entity)
        {
            _cv.Update(entity);
        }
    }
}
