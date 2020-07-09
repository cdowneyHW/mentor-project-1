using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mentor_Project_1.Data.DTOs
{
    public class CreateBlogResponse
    {
        public CreateBlogResponse(int blogID, string url) =>
            (this.BlogID, this.Url) = (blogID, url);

        public CreateBlogResponse() { }

        public int BlogID { get; set; }
        public string Url { get; set; }
    }
}
