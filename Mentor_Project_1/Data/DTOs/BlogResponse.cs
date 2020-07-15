using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mentor_Project_1.Data.DTOs
{
    public class BlogResponse
    {
        public BlogResponse(int blogID, string url) =>
            (this.BlogID, this.Url) = (blogID, url);

        public BlogResponse() { }

        public int BlogID { get; set; }
        public string Url { get; set; }
    }
}
