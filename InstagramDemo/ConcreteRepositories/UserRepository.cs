using InstagramDemo.AbstractRepositories;
using InstagramDemo.Data;
using InstagramDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.ConcreteRepositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public User GetUserByUsername(string username)
        {
            var user = _context.Users.FirstOrDefault(x=>x.Username==username);
            return user;
        }
    }
}
