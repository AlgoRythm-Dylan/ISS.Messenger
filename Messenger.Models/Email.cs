using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public class Email
    {
        public string From { get; set; }
        public List<string> To { get; set; } = new List<string>();
        public List<string> CC { get; set; } = new List<string>();
        public List<string> BCC { get; set; } = new List<string>();
        public string? Subject { get; set; }
        public string? Body { get; set; }
    }
}
