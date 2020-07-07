﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Mentor_Project_1.Data.Models
{
   /// <summary>
   /// 
   /// </summary>
    public class DataContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DataContext(IConfiguration configuration, DbContextOptions<DataContext> options) : base(options)
        {
            _configuration = configuration;
        }

 

        public DbSet<Blog> Blogs { get; set; }
        /*
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        */

 

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(_configuration.GetConnectionString("DbConnectionString"));
    }
}
