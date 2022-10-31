using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public class User
    {
        public long Seq { get; set; }
        public string ID { get; set; }
        public long EmployeeID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleInit { get; set; }
        public string LastName { get; set; }
        public string PrefFirstName { get; set; }
        public string Name { get; set; }
        public string ActiveInt { get; set; }
        public long EnployeeSeq { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string PhoneCell { get; set; }
        public long Level1Seq { get; set; }
        public DateTime? TerminationDate { get; set; }
    }
}
