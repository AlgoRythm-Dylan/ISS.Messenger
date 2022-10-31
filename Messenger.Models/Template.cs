using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public class Template
    {
        /// <summary>
        /// Numerical ID of the template
        /// </summary>
        public long Seq { get; set; }
        /// <summary>
        /// Friendly name of the template
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// A description for this template i.e. "Used in the 7 day email"
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// String ID (i.e. "MAIL_7D_OVERDUE") used to refer to the template
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// The source code of the template
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// The sequential, integer version number of a template.
        /// Each time a template is revised, it gets a new number
        /// </summary>
        public long Version { get; set; }
        /// <summary>
        /// Database representation of whether or not the template
        /// is enabled
        /// </summary>
        public int Enabled { get; set; }
        /// <summary>
        /// Convenience getter and setter for db data
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return Enabled == 1;
            }
            set
            {
                Enabled = value ? 1 : 0;
            }
        }
    }
}
