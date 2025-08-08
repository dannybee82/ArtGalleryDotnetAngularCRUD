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
                },
                new Style()
                {
                    Id = 6,
                    Name = "Old School Revivalism",
                    Description = "Art critics often give names to art movements. This is also the case with \"Old School Revivalism\". During an exhibition, art critic John Ruskin III Junior noted that the art was not new, outdated, had been seen before, and was reminiscent of the 'old masters' and thus claiming that it was \"Old School Revivalism.\" The artists themselves could not come up with a name for their art, but adopted this name from Ruskin Junior. The paintings and other works of art are often without any meaning."
                },
                new Style()
                {
                    Id = 7,
                    Name = "Neo Medievalism",
                    Description = "The art movement \"Neo-Medievalism\" is characterized by the glorification of and longing for a distant and nostalgic past. Recurring themes include: common folk, religion, medieval buildings and festivities. Closely related to this art movement is \"Neo-Mysticism,\" and there is an overlap between the artists of both movements."
                },
                new Style()
                {
                    Id = 8,
                    Name = "Neo Mysticism",
                    Description = "The art movement \"Neo-Mysticism\" often features medieval settings and visual elements. This art movement is closely related to the art movement \"Neo Medievalism,\". There is an overlap between the artists, but the themes vary, such as: mystical seers, healers, enigmatic figures and religious artifacts."
                }                
            };
        }

    }

}