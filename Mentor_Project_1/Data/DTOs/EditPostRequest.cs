using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mentor_Project_1.Data.DTOs
{
    public class EditPostRequest : PostRequest
    {
        public int PostID { get; set; }
    }
}
