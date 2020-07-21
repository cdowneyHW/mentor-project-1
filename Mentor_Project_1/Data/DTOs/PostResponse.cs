using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project_1.Data.Models;

namespace Mentor_Project_1.Data.DTOs
{
    public class PostResponse
    {
        public PostResponse() { }

        public PostResponse(Post post) => (PostID, Title, Content, BlogID, Blog) =
            (post.PostID, post.Title, post.Content, post.BlogID, post.Blog);

        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
