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
        public BlogRequest(string title, string description) => (Title, Description) = (title, description);

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
