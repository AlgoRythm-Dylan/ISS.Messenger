using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messenger.Models;

namespace Messenger.Services
{
    public interface ITemplateService
    {
        /// <summary>
        /// Get a template given a template ID, and optionally, a version
        /// number
        /// </summary>
        /// <param name="seq">Numerical, unique sequence of the template</param>
        /// <param name="version">Optional version number of template
        /// If null, returns latest version</param>
        /// <returns></returns>
        public Template? Get(long seq, long? version = null);
    }
}
