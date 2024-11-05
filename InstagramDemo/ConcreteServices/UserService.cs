using InstagramDemo.AbstractRepositories;
using InstagramDemo.AbstractServices;
using InstagramDemo.Entities; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.ConcreteServices
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _repository;
        private readonly IUserRepository _userRepository;

        public UserService(IGenericRepository<User> repository,IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }
        public void AddUser(User user)
        {
            _repository.Add(user);
        }

        public User GetUserByTryToLogin(string username, string password)
        {
            var allUsers = _repository.GetAll();
            var userTryToLogin = allUsers.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (userTryToLogin != null)
            {
                return userTryToLogin;
            }
            else
            {
                return null;
            }
        }

        public User GetUserByUsername(string username)
        {
            //return _userRepository.GetUserByUsername(username);

            var users = _repository.GetAll();
            //foreach (var user in users)
            //{
            //    if (user.Username == username)
            //    {
            //        return user;
            //    }
              
            //}

            var user = users.FirstOrDefault(x=>x.Username == username);
            return user;
        }

        public User Login(User user)
        {
            var allUsers = _repository.GetAll();

            var userTryToLogin = allUsers.FirstOrDefault(x=>x.Username==user.Username && x.Password==user.Password);

            if (userTryToLogin != null) 
            { 
                return userTryToLogin;
            }
            else
            {
                return null;
            }
        }

        public void UpdateUser(int id,User user)
        {
            _repository.Update(id,user);
        }
    }
}
