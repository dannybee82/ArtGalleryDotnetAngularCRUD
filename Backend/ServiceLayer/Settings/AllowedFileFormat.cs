using FileSignatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Settings
{
    public class AllowedFileFormat : IAllowedFileFormat
    {
        public string Extension { get; set; }
        public IEnumerable<FileFormat> FileFormat { get; set; }
    }
}
