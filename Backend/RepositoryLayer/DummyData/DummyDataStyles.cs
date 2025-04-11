using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.DummyData
{
    public class DummyDataStyles
    {

        public static List<Style> Create()
        {
            return new List<Style>()
            {
                new Style()
                {
                    Id = 1,
                    Name = "Floral Art",
                    Description = "Floral art combines ancestral knowledge with modern technique. The characteristics are beautiful arrangements that convey meaning and emotion with flowers, leaves, ornaments, etc. Like any art, Floral Art requires the technical mastery of a sensitive creative who is able to combine the elements they are working with in a special way."
                },
                new Style()
                {
                    Id = 2,
                    Name = "Neo Impressionism",
                    Description = "Neo Impressionism is characterized by visible brush strokes, open composition, emphasis on accurate depiction of light in its changing qualities, ordinary subject matter, unusual visual angles, and inclusion of movement as a crucial element of human perception and experience."
                },
                new Style()
                {
                    Id = 3,
                    Name = "Neo Rococo",
                    Description = "Neo Rococo is an exceptionally ornamental and dramatic style of art and decoration. It combines asymmetry, scrolling curves, gilding, white and pastel colours, sculpted moulding, and trompe-l'œil frescoes to create surprise and the illusion of motion and drama."
                },
                new Style()
                {
                    Id = 4,
                    Name = "Neo Symbolism",
                    Description = "Neo-Symbolism is opposed to Naturalism and Academic Art. It deals with themes such as the irrational, the world of dreams and fairy tales. It attempts to persuade the viewer to meditate and to transcend the material."
                },
                new Style()
                {
                    Id = 5,
                    Name = "Pixel Art",
                    Description = "Pixel art is a form of digital art drawn with graphical software where images are built using pixels as the only building block. It is widely associated with the low-resolution graphics."
                }
            };
        }

    }

}