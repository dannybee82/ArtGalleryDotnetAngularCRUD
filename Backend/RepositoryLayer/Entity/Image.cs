using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Entity
{

    [Table("Image", Schema = "ArtGallery")]
    public class Image
    {

        [Key]
        public int Id { get; set; }

        public string Base64 { get; set; } = string.Empty;

    }

}
