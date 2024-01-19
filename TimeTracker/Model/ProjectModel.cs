using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Domain;

namespace TimeTracker.Model
{
    public class ProjectModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }

        public static ProjectModel FromProject(Project project)
        {
            return new ProjectModel
            {
                Id = project.Id,
                Name = project.Name,
                ClientId = project.Client.Id,
                ClientName = project.Client.Name
            };
        }
    }
}