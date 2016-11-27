using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Models
{
    interface Person
    {
        string FirstName {get;set;}
        string LastName { get; set; }
        DateTime BirthDate { get; set; }
        Types.Types Gender { get; set; }
    }
}
