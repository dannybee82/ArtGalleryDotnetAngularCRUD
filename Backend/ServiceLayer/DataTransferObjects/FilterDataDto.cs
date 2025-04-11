using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DataTransferObjects
{
    public class FilterDataDto
    {

        public List<int>? Styles { get; set; }

        public List<int>? Artists { get; set; }

        public List<int>? Years { get; set; }

    }

}
