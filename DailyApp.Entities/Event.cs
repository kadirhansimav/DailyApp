using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyApp.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate   { get; set;} = DateTime.Now;

        public bool IsDeleted { get; set; } = false;
        public bool IsDone { get; set; }
    }
}
