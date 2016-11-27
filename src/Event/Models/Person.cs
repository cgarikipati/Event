using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Models
{
    interface IPerson
    {
        string FirstName {get;set;}
        string LastName { get; set; }
        DateTime BirthDate { get; set; }
        Types.Gender Gender { get; set; }

        Account Account { get; set; }

        string AvatarUrl { get; set; }

    }
}
