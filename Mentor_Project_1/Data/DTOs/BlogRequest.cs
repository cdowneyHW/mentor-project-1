using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Mentor_Project_1.Data.DTOs
{
    public class BlogRequest
    {
        public BlogRequest() { }
        public BlogRequest(string url) => Url = url;
        public BlogRequest(BlogRequest copy) => Url = copy.Url;

        public string Url { get; set; }
    }
}
