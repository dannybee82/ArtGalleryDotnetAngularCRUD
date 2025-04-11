using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Entity
{

    [Table("Thumbnail", Schema = "ArtGallery")]
    public class Thumbnail
    {
        [Key]
        public int Id { get; set; }

        public string Base64 { get; set; } = string.Empty;

        public int? ParentImageId { get; set; }
    }

}