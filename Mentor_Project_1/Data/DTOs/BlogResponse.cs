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

        public BlogResponse(Blog blog)
        {
            (BlogID, Url) = (blog.BlogID, blog.Url);
            GeneratePostResponses(blog.Posts);
        }

        public int BlogID { get; set; }
        public string Url { get; set; }
        public List<PostResponse> Posts { get; } = new List<PostResponse>();

        private void GeneratePostResponses(List<Post> realPosts)
        {
            foreach (var post in realPosts)
            {
                Posts.Add(new PostResponse(post));
            }
        }
    }
}
