using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project_1.Data.Models;

namespace Mentor_Project_1.Data.DTOs
{
    public class GetBlogResponse : BlogResponse
    {
        public GetBlogResponse() {}

        public GetBlogReponse(Blog blog) : base(blog)
        {
            GeneratePostReponses(blog.Posts);
        }
        public List<PostResponse> Posts { get; } = new List<PostResponse>();

        private void GeneratePostResponses(List<Post> realPosts)
        {   // this generates a list of Post Responses that are safe for the delete function
            foreach (var post in realPosts)
            {
                Posts.Add(new PostResponse(post));
            }
        }
    }
}
