using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public class ServiceArea
    {
        /// <summary>
        /// Unique numerical identifier of this service area
        /// </summary>
        public long Seq { get; set; }
        /// <summary>
        /// Shorthand service area code, ex, AP1
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Name of service area, ex, Network Infrastructure Services
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Active - Y or N
        /// </summary>
        public string ActiveInd { get; set; }
        /// <summary>
        /// Service Area Group sequence
        /// </summary>
        public long GroupSeq { get; set; }
        /// <summary>
        /// HR top level organization seq
        /// </summary>
        public long Level1OrgSeq { get; set; }
    }
}
