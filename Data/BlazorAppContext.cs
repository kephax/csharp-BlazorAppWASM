using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Model;

namespace BlazorApp.Data
{
    public class BlazorAppContext : DbContext
    {
        public BlazorAppContext (DbContextOptions<BlazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp.Model.Monkey> Monkey { get; set; } = default!;
    }
}
