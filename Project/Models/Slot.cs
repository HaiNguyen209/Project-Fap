using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Slot
    {
        public Slot()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public DateTime? LearningTime { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
