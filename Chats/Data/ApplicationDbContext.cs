using System;
using System.Collections.Generic;
using System.Text;
using Chats.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Chats.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Topics> Topics { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
