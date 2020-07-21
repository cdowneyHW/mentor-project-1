using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mentor_Project_1.Data.DTOs
{
    public class PostRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }
        
        public int BlogID { get; set; }
    }
}
