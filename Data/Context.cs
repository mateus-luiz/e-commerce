using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {}

        public DbSet<GameModel>? Games { get;  set; }
    }
}