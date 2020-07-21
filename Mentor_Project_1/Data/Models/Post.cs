using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project_1.Data.DTOs;

namespace Mentor_Project_1.Data.Models
{
    public class Post
    {
        public Post() {}
        public Post(PostRequest request) => (Title, Content, BlogID) = (request.Title, request.Content, request.BlogID);
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
