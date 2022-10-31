using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Models
{
    /// <summary>
    /// Linking entity between a job and the time it is
    /// supposed to run. A job can run according to many
    /// different schedules
    /// </summary>
    public class JobCalendar : Disableable
    {
        /// <summary>
        /// The job that is run according to the corresponding
        /// schedule
        /// </summary>
        public Job Job { get; set; }
        /// <summary>
        /// The schedule which the corresponding job runs at
        /// </summary>
        public Schedule Schedule { get; set; }
    }
}
