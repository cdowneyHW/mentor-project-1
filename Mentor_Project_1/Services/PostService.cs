using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project_1.Data.DTOs;
using Mentor_Project_1.Data.Models;

namespace Mentor_Project_1.Services
{
    public class PostService
    {
        private readonly DataContext _dataContext;
        public PostService(DataContext dc) => _dataContext = dc;

        public PostResponse CreatePost(PostRequest request)
        {
            var newPost = new Post(request);
            newPost.Blog = _dataContext.Blogs.Find(newPost.BlogID);
            newPost.Blog.Posts.Add(newPost);
            var response = _dataContext.SaveChanges();

            return new PostResponse(newPost);
        }

        public PostResponse GetPost(int PostID)
        {
            var post = _dataContext.Posts.Find(PostID);
            return new PostResponse(post);
        }

        public PostResponse EditPost(EditPostRequest request)
        {
            var post = _dataContext.Posts.Find(request.PostID);
            if (post.BlogID != request.BlogID)
            {   // updates source blog if changed
                post.Blog.Posts.Remove(post);
                post.Blog = _dataContext.Blogs.Find(request.BlogID);
                post.Blog.Posts.Add(post);
            }
            (post.Title, post.Content, post.BlogID) = (request.Title, request.Content, request.PostID);
            var response = _dataContext.SaveChanges();

            return new PostResponse(post);
        }

        public PostResponse DeletePost(int PostID)
        {
            var TempPost = _dataContext.Posts.Find(PostID);
            var TempResponse = new PostResponse(TempPost);
            _dataContext.Blogs.Find(TempPost.BlogID).Posts.Remove(TempPost);
            _dataContext.Remove(TempPost);
            var response = _dataContext.SaveChanges();
            return TempResponse;
        }

        public List<PostResponse> ListPosts()
        {
            // lists all posts, not filtered by blog
            var Posts = _dataContext.Posts.AsQueryable().ToList();
            var PostResponses = new List<PostResponse>(Posts.Count);

            foreach (var post in Posts)
            {
                PostResponses.Add(new PostResponse(post));
            }

            return PostResponses;
        }
    }
}
