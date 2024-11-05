using InstagramDemo.AbstractRepositories;
using InstagramDemo.Data;
using InstagramDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.ConcreteRepositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseClass
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entities;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public void Add(T entity)
        {
            
            _entities.Add(entity);
            _context.SaveChanges();

        }

        public void AddRange(List<T> entities)
        {
            _entities.AddRange(entities);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(x=>x.Id==id);
        }

        public void Update(int id, T entity)
        {
            var entityToUpdate = GetById(id);
            entityToUpdate.CreatedDate = DateTime.Now;
            _entities.Update(entityToUpdate);
            _context.SaveChanges();
        }

        //IUserService ve UserService oluşturup doldurun.
    }
}
