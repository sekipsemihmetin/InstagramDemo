using InstagramDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.AbstractServices
{
    public interface IUserService
    {
        void AddUser(User user);

        User GetUserByUsername(string username);

        User Login(User user);

        User GetUserByTryToLogin(string username,string password);

        void UpdateUser(int id,User user);
    }
}
