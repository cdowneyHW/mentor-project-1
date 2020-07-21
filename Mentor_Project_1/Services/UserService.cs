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

        public UserResponse CreateUser(UserRequest request)
        {
            var newUser = new User(request);
            _dataContext.Users.Add(newUser);
            var response = _dataContext.SaveChanges();
            return new UserResponse(newUser);
        }

        public UserResponse GetUser(int id)
        {
            var tempUser = _dataContext.Users.Find(id);

            return new UserResponse(tempUser);
        }

        public UserResponse EditUser(EditUserRequest request)
        {
            var tempUser = _dataContext.Users.Find(request.UserID);

            tempUser.FirstName = request.FirstName;
            tempUser.LastName = request.LastName;

            var response = _dataContext.SaveChanges();

            return new UserResponse(tempUser);
        }

        public UserResponse DeleteUser(int id)
        {
            var tempUser = _dataContext.Users.Find(id);
            var tempUserResponse = new UserResponse(tempUser);

            _dataContext.Remove(tempUser);

            var response = _dataContext.SaveChanges();

            return tempUserResponse;
        }

        public List<UserResponse> ListUsers()
        {
            var users = _dataContext.Users.AsQueryable().ToList();
            var tempList = new List<UserResponse>(users.Count);

            foreach (var user in users)
            {
                tempList.Add(new UserResponse(user));
            }

            return tempList;
        }
    }
}
