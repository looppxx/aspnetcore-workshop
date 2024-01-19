using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Domain;

namespace TimeTracker.Model
{
    public class UserModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal HourRate { get; set; }

        public static UserModel FromUser(User user)
        {
            return new UserModel
            {
                Id = user.Id,
                Name = user.Name,
                HourRate = user.HourRate
            };
        }
    }
}