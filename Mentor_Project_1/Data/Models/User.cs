using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project_1.Data.DTOs;

namespace Mentor_Project_1.Data.Models
{
    public class User
    {
        public User() {}
        public User(UserRequest user) => (FirstName, LastName) = (user.FirstName, user.LastName);
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
