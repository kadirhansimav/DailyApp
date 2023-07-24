using DailyApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyApp.DataAccess
{
    public class DailyContext:DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}
