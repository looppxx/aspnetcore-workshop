using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Model
{
    public class TimeEntryInputModel
    {
        public long UserId { get; set; }
        public long ProjectId { get; set; }
        public DateTime EntryDate { get; set; }
        public int Hours { get; set; }
        public string Description { get; set; }

        public void MapTo(TimeEntry timeEntry)
        {
            timeEntry.EntryDate = EntryDate;
            timeEntry.Hours = Hours;
            timeEntry.Description = Description;
        }
    }
}