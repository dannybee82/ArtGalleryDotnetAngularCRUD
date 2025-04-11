using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Entities
{

    [Table("Artist", Schema = "ArtGallery")]
    public class Artist
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; } = string.Empty;

        public int? YearOfBirth { get; set; }

        public int? YearOfDeath { get; set; }
        
    }

}
