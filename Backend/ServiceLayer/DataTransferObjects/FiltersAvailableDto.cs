using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DataTransferObjects
{
    public class FiltersAvailableDto
    {
        public List<FilterItemDto> Styles { get; set; } = new List<FilterItemDto>();

        public List<FilterItemDto> Artists { get; set; } = new List<FilterItemDto>();

        public List<FilterItemDto> Years { get; set; } = new List<FilterItemDto>();

    }
}
