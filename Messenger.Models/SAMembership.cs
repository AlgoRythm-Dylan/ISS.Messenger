using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public class SAMembership
    {
        public long Seq { get; set; }
        public User User { get; set; }
        public ServiceArea ServiceArea { get; set; }
        public string MembershipType { get; set; }
        public string ActiveInd { get; set; }
    }
}
