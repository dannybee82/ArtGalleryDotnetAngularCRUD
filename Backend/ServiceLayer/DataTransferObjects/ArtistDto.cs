using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DataTransferObjects
{
    public class ArtistDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; } = string.Empty;

        public int? YearOfBirth { get; set; }

        public int? YearOfDeath { get; set; }

    }

}
