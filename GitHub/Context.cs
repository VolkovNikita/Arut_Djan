using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    class Context : DbContext
    {
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
