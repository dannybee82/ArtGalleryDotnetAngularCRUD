using FileSignatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Settings
{
    public interface IAllowedFileFormat
    {
        string Extension { get; set; }

        IEnumerable<FileFormat> FileFormat { get; set; }
    }

}
