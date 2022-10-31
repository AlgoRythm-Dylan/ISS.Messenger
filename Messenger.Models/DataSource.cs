using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public class DataSource
    {
        /// <summary>
        /// Unique numerical sequence for this data source
        /// </summary>
        public long Seq { get; set; }
        /// <summary>
        /// Friendly name for this data source
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of this data source
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The data source type
        /// 1: SQL
        /// 2: HTTP
        /// </summary>
        public int DataSourceType { get; set; }
        /// <summary>
        /// A reference sequence to the related data
        /// source (SQL or HTTP). HTTP has a lot of
        /// properties which need to be stored in multiple
        /// tables
        /// </summary>
        public long? DataSourceRef { get; set; }
    }
}
