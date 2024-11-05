using InstagramDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.AbstractRepositories
{
    public interface IGenericRepository<T> where T : BaseClass
    {
        void Add(T entity); 
        void Update(int id,T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
        void AddRange(List<T> entities);
    }
}
