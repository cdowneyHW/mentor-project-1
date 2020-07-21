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
    public class PostController : ControllerBase
    {
        private readonly PostService _service;
        public PostController(PostService service) => _service = service;

        [HttpPost]
        public PostResponse CreatePost(PostRequest request) => _service.CreatePost(request);

        [HttpGet]
        public PostResponse GetPost(int PostID) => _service.GetPost(PostID);

        [HttpPut]
        public PostResponse EditPost(EditPostRequest request) => _service.EditPost(request);

        [HttpDelete]
        public PostResponse DeletePost(int PostID) => _service.DeletePost(PostID);

        [HttpGet]
        public List<PostResponse> ListPosts() => _service.ListPosts();
    }
}
