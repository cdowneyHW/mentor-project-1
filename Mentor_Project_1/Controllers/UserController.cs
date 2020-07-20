using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project_1.Data.DTOs;
using Mentor_Project_1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mentor_Project_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service) => _service = service;

        [HttpPost]
        public UserResponse CreateUser(UserRequest request) => _service.CreateUser(request);

        [HttpGet]
        public UserResponse GetUser(int id) => _service.GetUser(id);

        [HttpPut]
        public UserResponse EditUser(EditUserRequest request) => _service.EditUser(request);

        [HttpDelete]
        public UserResponse DeleteUser(int id) => _service.DeleteUser(id);

        [HttpGet]
        public List<UserResponse> ListUsers() => _service.ListUsers();

    }
}
