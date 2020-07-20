using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project_1.Data.DTOs;
using Mentor_Project_1.Data.Models;

namespace Mentor_Project_1.Services
{
    public class UserService
    {
        private readonly DataContext _dataContext;
        public UserService(DataContext dataContext) => _dataContext = dataContext;

        public UserResponse CreateUser(UserRequest user)
        {
            var newUser = new User(user);
            _dataContext.Users.Add(newUser);
            var response = _dataContext.SaveChanges();
            return new UserResponse(newUser);
        }

    }
}
