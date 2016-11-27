using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Models
{
    public class Types
    {
        public enum Gender  {
            MALE,
            FEMALE,
            OTHER,
            UNKNOWN
        };

        public enum AccountType
        {
            ADMIN,
            TENANT_ADMIN,
            AGGREGATE_INFO_USER,
            COACH,
            PLAYER,
            SUBSCRIBER,
            VOLUNTEER
        }

        public enum Challenges{
            LINE_FOLLOWING,
            AMAZING,
            FIRE_FIGHTING,
            ROBOTOVATE
        }

        public enum Roles
        {
            PLAYER,
            COACH,
            JUDGE,
            VOLUNTEER,
            SPONSOR,
        }
    }
}
