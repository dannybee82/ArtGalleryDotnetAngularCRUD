using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Entity
{

    [Table("Painting", Schema = "ArtGallery")]
    public class Painting
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Year { get; set; }

        [ForeignKey("Artist")]
        public int? ArtistId { get; set; }

        public Artist? Artist { get; set; }

        [ForeignKey("Style")]
        public int? StyleId { get; set; }

        public Style? Style { get; set; }

        [ForeignKey("Image")]
        public int? ImageId { get; set; }

        public Image? Image { get; set; }

        [ForeignKey("Thumbnail")]
        public int? ThumbnailId { get; set; }

        public Thumbnail? Thumbnail { get; set; }

    }

}