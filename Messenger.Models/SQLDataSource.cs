using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public class SQLDataSource
    {
        /// <summary>
        /// Unique numerical sequence of this SQL data source
        /// </summary>
        public long Seq { get; set; }
        /// <summary>
        /// The SQL query to provide data to the job
        /// </summary>
        public string Query { get; set; }
        /// <summary>
        /// The column to use for the "to" field in the
        /// e-mail. Default: "EMAIL_TO". If null,
        /// no column is used to generate the "to" field
        /// </summary>
        public string? ToColumn { get; set; } = "EMAIL_TO";
        /// <summary>
        /// The column to use for the "CC" field in the
        /// e-mail. Default: "EMAIL_CC". If null,
        /// no column is used to generate the "CC" field
        /// </summary>
        public string? CCColumn { get; set; } = "EMAIL_CC";
        /// <summary>
        /// The column to use for the "BCC" field in the
        /// e-mail. Default: "EMAIL_BCC". If null,
        /// no column is used to generate the "BCC" field
        /// </summary>
        public string? BCCColumn { get; set; } = "EMAIL_BCC";
    }
}
