using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DataTransferObjects
{
    public class ImageDto
    {

        public int? Id { get; set; }
        public string Base64 { get; set; } = string.Empty;

    }

}