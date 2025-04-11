using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Settings
{
    public class AllowedFileFormatList : IAllowedFileFormatList
    {
        public List<AllowedFileFormat> AllowedFileList { get; set; }
    }
}
