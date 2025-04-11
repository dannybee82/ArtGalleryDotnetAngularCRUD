using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ServiceLayer.DataTransferObjects
{
    public class PaintingDto
    {
        public int? Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Year { get; set; }

        public ArtistDto? Artist { get; set; }

        public StyleDto? Style { get; set; }

        public ImageDto? Image { get; set; }

        public ThumbnailDto? Thumbnail { get; set; }

    }

}