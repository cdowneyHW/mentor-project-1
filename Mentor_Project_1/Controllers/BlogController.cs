using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project_1.Data.DTOs;
using Mentor_Project_1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Mentor_Project_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BlogService _service;

        BlogController(BlogService service) => _service = service;

        [HttpPost]
        public CreateBlogResponse CreateBlog(CreateBlogRequest request) => _service.CreateBlog(request);

        [HttpGet]
        public CreateBlogResponse GetBlog(CreateBlogRequest request) => _service.GetBlog(request);
    }
}
