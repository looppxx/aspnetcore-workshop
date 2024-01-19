using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Model
{
    public class TimeEntryModel
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public long ProjectId { get; set; }
        public string ProjectName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public DateTime EntryDate { get; set; }
        public int Hours { get; set; }
        public decimal HourRate { get; set; }
        public string Description { get; set; }

        public static TimeEntryModel FromTimeEntry(TimeEntry timeEntry)
        {
            return new TimeEntryModel
            {
                Id = timeEntry.Id,
                UserId = timeEntry.User.Id,
                UserName = timeEntry.User.Name,
                ProjectId = timeEntry.Project.Id,
                ProjectName = timeEntry.Project.Name,
                ClientId = timeEntry.Project.Client.Id,
                ClientName = timeEntry.Project.Client.Name,
                EntryDate = timeEntry.EntryDate,
                Hours = timeEntry.Hours,
                HourRate = timeEntry.HourRate,
                Description = timeEntry.Description
            };
        }
    }
}