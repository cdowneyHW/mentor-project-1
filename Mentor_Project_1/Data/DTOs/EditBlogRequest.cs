using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Mentor_Project_1.Data.DTOs
{
    public class EditBlogRequest : BlogRequest
    {
        public int BlogID;
    }
}
