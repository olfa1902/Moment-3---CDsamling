using Microsoft.EntityFrameworkCore;
using Moment_3___CDsamling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moment_3___CDsamling.data
{
    public class CDContext: DbContext
    {
        public CDContext(DbContextOptions<CDContext> options) : base(options)
        {

        }

        public DbSet<CDskivor> CDskivor { get; set; }
    }
}
