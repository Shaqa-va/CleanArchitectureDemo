using Microsoft.EntityFrameworkCore;
using CleanArc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Infra.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }

    }
}
