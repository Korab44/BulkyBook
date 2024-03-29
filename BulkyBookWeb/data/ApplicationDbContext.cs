﻿using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
