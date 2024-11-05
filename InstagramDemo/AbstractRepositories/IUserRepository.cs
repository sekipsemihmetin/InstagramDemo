using InstagramDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.AbstractRepositories
{
    public interface IUserRepository
    {
        User GetUserByUsername(string username);
    }
}
