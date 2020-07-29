using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Mentor_Project_1.Data.DTOs;
using Mentor_Project_1.Data.Models;

namespace Mentor_Project_1.Services
{
    public class BlogService
    {
        private readonly DataContext _dataContext;

        public BlogService(DataContext dataContext) => _dataContext = dataContext;

        public BlogResponse CreateBlog(CreateBlogRequest blog)
        {
            // the new object we are going to save
            var newBlog = new Blog(blog);
            
            // This tells EntityFramework to add the new blog to the in memory version of our datacontext
            _dataContext.Blogs.Add(newBlog);

            // This tells EntityFramework to save all of our built up changes in our in memory version of the data
            // To the database
            var response = _dataContext.SaveChanges();

            return new BlogResponse(newBlog);

        }

        public GetBlogResponse GetBlog(int ID)
        {
            // includes a list of all posts in response
            // finds the blog with the matching url?
            var tempBlog = _dataContext.Blogs.Find(ID);

            // returns new instance of BlogResponse with properties matching the blog found
            return new GetBlogResponse(tempBlog);

        }

        public BlogResponse EditBlog(EditBlogRequest request)
        {
            // first need to find the blog to edit
            var tempBlog = _dataContext.Blogs.Find(request.BlogID);
            (tempBlog.Title, tempBlog.Description) = (request.Title, request.Description);

            var response = _dataContext.SaveChanges();

            return new BlogResponse(tempBlog);
        }

        public BlogResponse DeleteBlog(int ID)
        {
            // deletes blog and all posts in blog
            var tempBlog = _dataContext.Blogs.Find(ID);
            var tempBlogResponse = new BlogResponse(tempBlog);
            foreach (var post in tempBlog.Posts)
            {   // deletes every post in blog so that there aren't unassigned posts
                _dataContext.Posts.Remove(post);
            }
            _dataContext.Blogs.Remove(tempBlog);

            var response = _dataContext.SaveChanges();

            return tempBlogResponse;
        }

        public List<BlogResponse> ListBlogs()
        {
            // not so sure about this one
            var blogs = _dataContext.Blogs.AsQueryable().ToList();
            var tempList = new List<BlogResponse>(blogs.Count);

            foreach (var blog in blogs)
            {
                tempList.Add(new BlogResponse(blog));
            }

            // should I return array or list?
            return tempList;
        }
    }
}
