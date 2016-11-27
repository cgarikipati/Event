using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Models
{
    public class Team
    {
        public string Name { get; set; }
        public string AvatarUrl { get; set; }
        public string Id { get; set; }
        public List<IEvent> Events { get; set; }
    }
}
