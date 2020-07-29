using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project_1.Data.Models;

namespace Mentor_Project_1.Data.DTOs
{
    public class BlogResponse
    {
        public BlogResponse() { }

        public BlogResponse(Blog blog) => (BlogID, Title, Description) = (blog.BlogID, blog.Title, blog.Description);

        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
