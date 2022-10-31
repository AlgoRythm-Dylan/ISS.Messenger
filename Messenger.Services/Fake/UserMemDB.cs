using Messenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Services.Fake
{
    public static class UserMemDB
    {
        public static List<User> Users = new List<User>()
        {
            new User
            {
                Seq = 52756,
                ID = "dperunko",
                Email = "dperunko@comcast.net",
                Name = "Dylan Perunko",
                ActiveInd = "Y",
                EmployeeSeq = 48455,
                Level1Seq = 30
            }
        };
    }
}
