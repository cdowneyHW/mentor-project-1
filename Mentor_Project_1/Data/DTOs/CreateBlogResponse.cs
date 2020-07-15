using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mentor_Project_1.Data.DTOs
{
    public class CreateBlogResponse : BlogResponse
    {
        public CreateBlogResponse(int blogID, string url) : base(blogID, url) { }
        public CreateBlogResponse() : base() { }

    }
}
