using BussinesLayer.Abstract;
using DataLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class IsIlaniManager : IService<IsIlanı>
    {
        GenericRepository<IsIlanı> _job = new GenericRepository<IsIlanı>();
        public void Add(IsIlanı entity)
        {
            _job.Insert(entity);
        }

        public void Delete(IsIlanı entity)
        {
            _job.Delete(entity);
        }

        public IsIlanı GetById(int id)
        {
            return _job.Get(x=>x.ID == id);
        }

        public List<IsIlanı> List()
        {
            return _job.List();
        }

        public List<IsIlanı> List(Expression<Func<IsIlanı, bool>> filter)
        {
            return _job.List();
        }

        public void Update(IsIlanı entity)
        {
            _job.Update(entity);
        }
    }
}
