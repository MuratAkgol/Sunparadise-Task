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
    public class EgitimManager : IService<Egitim>
    {
        GenericRepository<Egitim> _egitim = new GenericRepository<Egitim>();
        public void Add(Egitim entity)
        {
            _egitim.Insert(entity);
        }

        public void Delete(Egitim entity)
        {
            _egitim.Delete(entity);
        }

        public Egitim GetById(int id)
        {
            return _egitim.Get(x => x.Id == id);
        }

        public List<Egitim> List()
        {
            return _egitim.List();
        }

        public List<Egitim> List(Expression<Func<Egitim, bool>> filter)
        {
            return _egitim.List();
        }

        public void Update(Egitim entity)
        {
            _egitim.Update(entity);
        }
    }
}
