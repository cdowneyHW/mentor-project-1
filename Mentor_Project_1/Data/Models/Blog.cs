using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project_1.Data.DTOs;

namespace Mentor_Project_1.Data.Models
{
    // simple blog class
    public class Blog
    {
        public Blog() { }
        public Blog(BlogRequest request) => (Title, Description) = (request.Title, request.Description);
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Post> Posts { get; } = new List<Post>();
    }
}
