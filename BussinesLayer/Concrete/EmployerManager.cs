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
    public class EmployerManager : IService<Employer>
    {
        GenericRepository<Employer> _employer = new GenericRepository<Employer>();
        public void Add(Employer entity)
        {
            _employer.Insert(entity);
        }

        public void Delete(Employer entity)
        {
            _employer.Delete(entity);
        }

        public Employer GetById(int id)
        {
            return _employer.Get(x => x.Id == id);
        }

        public List<Employer> List()
        {
            return _employer.List();
        }

        public List<Employer> List(Expression<Func<Employer, bool>> filter)
        {
            return _employer.List();
        }

        public void Update(Employer entity)
        {
            _employer.Update(entity);
        }
    }
}
