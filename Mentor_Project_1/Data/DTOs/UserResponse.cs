using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project_1.Data.Models;

namespace Mentor_Project_1.Data.DTOs
{
    public class UserResponse
    {
        public UserResponse() {}
        public UserResponse(User user) => (UserID, FirstName, LastName) = (user.UserID, user.FirstName, user.LastName);
        public int UserID;
        public string FirstName;
        public string LastName;
    }
}
