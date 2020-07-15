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

        public CreateBlogResponse CreateBlog(CreateBlogRequest blog)
        {
            // the new object we are going to save
            var newBlog = new Blog()
            {
                Url = blog.Url
            };

            // This tells EntityFramework to add the new blog to the in memory version of our datacontext
            _dataContext.Blogs.Add(newBlog);

            // This tells EntityFramework to save all of our built up changes in our in memory version of the data
            // To the database
            var response = _dataContext.SaveChanges();

            return new CreateBlogResponse(newBlog.BlogID, newBlog.Url);

        }

        public BlogResponse GetBlog(int ID)
        {
            // finds the blog with the matching url?
            var tempBlog = _dataContext.Blogs.Find(ID);

            // returns new instance of BlogResponse with properties matching the blog found
            return new BlogResponse(tempBlog.BlogID, tempBlog.Url);

        }

        public BlogResponse EditBlog(EditBlogRequest blog)
        {
            // first need to find the blog to edit
            var tempBlog = _dataContext.Blogs.Find(blog.ID);
            tempBlog.Url = blog.ModBlog.Url;

            var response = _dataContext.SaveChanges();

            return new BlogResponse(tempBlog.BlogID, tempBlog.Url);
        }

        public BlogResponse DeleteBlog(int ID)
        {
            var tempBlog = _dataContext.Blogs.Find(ID);
            _dataContext.Blogs.Remove(tempBlog);

            var response = _dataContext.SaveChanges();

            return new BlogResponse(tempBlog.BlogID, tempBlog.Url);
        }

        public List<BlogResponse> ListBlogs()
        {
            // not so sure about this one
            var blogs = _dataContext.Blogs.AsQueryable().ToList();
            var tempList = new List<BlogResponse>();

            foreach (var blog in blogs)
            {
                tempList.Add(new BlogResponse(blog.BlogID, blog.Url));
            }

            // should I return array or list?
            return tempList;
        }
    }
}
