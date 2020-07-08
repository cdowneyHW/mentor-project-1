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

            return
                new CreateBlogResponse()
                {
                    Url = newBlog.Url,
                    BlogID = newBlog.BlogID
                }; //notice that there is a number in this field now, this is because this Id was created by the sql database and EntityFramework set the value when we saved the record

        }

    }
}
