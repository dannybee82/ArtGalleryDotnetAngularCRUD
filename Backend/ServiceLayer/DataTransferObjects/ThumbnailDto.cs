using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DataTransferObjects
{
    public class ThumbnailDto
    {

        public int? Id { get; set; }

        public string Base64 { get; set; } = string.Empty;

        public int? ParentImageId { get; set; }
    }

}