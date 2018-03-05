﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreSample
{
    public class BooksContext : DbContext
    {
        //public BooksContext()
        //{

        //}

        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => base.OnConfiguring(optionsBuilder);
    }
}
