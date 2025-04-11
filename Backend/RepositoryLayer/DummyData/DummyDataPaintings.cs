using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.DummyData
{
    public class DummyDataPaintings
    {

        public static List<Painting> Create()
        {
            return new List<Painting>()
            {
                new Painting()
                {
                    Id = 1,
                    Name = "Rites of Spring",
                    Description = "The first piece of the painter Jean Millet. The painting depicts a beautiful day in spring. With both a playful and colorful palette.",
                    Year = 1993,
                    ArtistId = 1,
                    StyleId = 1,
                    ImageId = 1,
                    ThumbnailId = 1
                },
                new Painting()
                {
                    Id = 2,
                    Name = "A Cloudy Day in Spring",
                    Description = "The painter Jean Millet his second painting. The painting depicts a cloudy day in spring. His muse knows how to enchant with her penetrating gaze.",
                    Year = 1995,
                    ArtistId = 1,
                    StyleId = 1,
                    ImageId = 2,
                    ThumbnailId = 2
                },
                new Painting()
                {
                    Id = 3,
                    Name = "The Height of Spring",
                    Description = "The third painting of Jean Millet. With his playful colour palette, the painter captures the spring season well. This painting was the pinnacle of his career, in which he achieved virtuosity.",
                    Year = 1997,
                    ArtistId = 1,
                    StyleId = 1,
                    ImageId = 3,
                    ThumbnailId = 3
                },
                new Painting()
                {
                    Id = 4,
                    Name = "Matilda du Mal and the Flowers of Kindness",
                    Description = "This is Norbert Nikolaus' first painting completed under the supervision of his master (Jean Millet). The painting is a portrait of a woman in a a summery flower landscape. The title suggests that there is a certain duality between kindness and evil.",
                    Year = 1998,
                    ArtistId = 2,
                    StyleId = 1,
                    ImageId = 4,
                    ThumbnailId = 4
                },
                new Painting()
                {
                    Id = 5,
                    Name = "Saskia des Esseintes in the Sacred Garden",
                    Description = "The second painting of Norbert Nikolaus. The painting shows a young woman in a rich floral landscape. It is probably mid-summer. The castle in the background adds an extra element of mystery.",
                    Year = 2000,
                    ArtistId = 2,
                    StyleId = 1,
                    ImageId = 5,
                    ThumbnailId = 5
                },
                new Painting()
                {
                    Id = 6,
                    Name = "Youthfull and Mysterious Purple",
                    Description = "The painter captures the color purple in a brilliant way. This color symbolizes mysticism, youth and spontaneity. It is the synthesis of red (life) and blue (ratio).",
                    Year = 2012,
                    ArtistId = 3,
                    StyleId = 2,
                    ImageId = 6,
                    ThumbnailId = 6
                },
                new Painting()
                {
                    Id = 7,
                    Name = "A Meditative Blue",
                    Description = "The painting shows a woman who is lost in her own thoughts. The meditative effect is enhanced by the blue and yellow color. The painting transcends the material and challenges the viewer to inner meditation.",
                    Year = 2014,
                    ArtistId = 3,
                    StyleId = 2,
                    ImageId = 7,
                    ThumbnailId = 7
                },
                new Painting()
                {
                    Id = 8,
                    Name = "Becoming One With Nature",
                    Description = "This painting was made especially for the congress to save the nature in 2016. It shows a young woman with green eyes in a natural green landscape. The symbolism consists of the natural link between growing and experiencing. Another meaning is that this woman has managed to achieve balance through nature.",
                    Year = 2016,
                    ArtistId = 3,
                    StyleId = 2,
                    ImageId = 8,
                    ThumbnailId = 8
                },
                new Painting()
                {
                    Id = 9,
                    Name = "A Quiet And Relaxing Moment",
                    Description = "The dominant green and brown color radiate peace and relaxation. The painting shows a girl sitting with her back against a wall. The painter encourages the viewer to think of a moment of rest.",
                    Year = 2017,
                    ArtistId = 3,
                    StyleId = 2,
                    ImageId = 9,
                    ThumbnailId = 9
                },
                new Painting()
                {
                    Id = 10,
                    Name = "Energies Of Light",
                    Description = "The painting shows a vital woman in the prime of her life. The golden color represents the light that brings energy and prosperity. Without light, there is no growth possible in nature, which is shown on the right.",
                    Year = 2018,
                    ArtistId = 3,
                    StyleId = 2,
                    ImageId = 10,
                    ThumbnailId = 10
                },
                new Painting()
                {
                    Id = 11,
                    Name = "Juliette Wolpertinger In The Evening Twilight",
                    Description = "A typical painting made in Neo-Rococo style. The painter Gabriel Gale portrays his personal obsession, namely the woman Juliette Wolpertinger. She is depicted in the evening twilight, which is the transition from day to night and symbolizes the fading hopes and memories.",
                    Year = 1990,
                    ArtistId = 4,
                    StyleId = 3,
                    ImageId = 11,
                    ThumbnailId = 11
                },
                new Painting()
                {
                    Id = 12,
                    Name = "Juliette Wolpertinger In The Living Room",
                    Description = "A portrait of Juliette Wolpertinger in the living room. The painter shows playful elements from the Neo-Rococo style and combines this with a lavish ornament. Juliette Wolpertinger was the obsession and fantasy of the painter Gabriel Gale.",
                    Year = 1991,
                    ArtistId = 4,
                    StyleId = 3,
                    ImageId = 12,
                    ThumbnailId = 12
                },
                new Painting()
                {
                    Id = 13,
                    Name = "Juliette Wolpertinger In Adulthood",
                    Description = "A later portrait of Juliette Wolpertinger painted by the painter Gabriel Gale. Due to her age, her hair has changed from red to blond. The painter still follows the style of Neo-Rococo with decorations, ornament and playful details.",
                    Year = 1999,
                    ArtistId = 4,
                    StyleId = 3,
                    ImageId = 13,
                    ThumbnailId = 13
                },
                new Painting()
                {
                    Id = 14,
                    Name = "Nobilis Venus Rosis",
                    Description = "The Latin title means: Noble Venus with roses. This playful portrait of an unknown noblewoman is adorned with various floral motifs, painted in subdued colours and radiates light amusement. The painter - Gabriel Gale - has expressed the characteristics of the Neo-Rococo with this painting.",
                    Year = 1993,
                    ArtistId = 4,
                    StyleId = 3,
                    ImageId = 14,
                    ThumbnailId = 14
                },
                new Painting()
                {
                    Id = 15,
                    Name = "Noblewoman In Turquoise Blouse",
                    Description = "A portrait of an unknown noblewoman. The woman has playful hair and ear jewelry. The background is decorated with gold colored ornaments. The painter Gabriel Gale considers this painting to be one of his masterpieces.",
                    Year = 1994,
                    ArtistId = 4,
                    StyleId = 3,
                    ImageId = 15,
                    ThumbnailId = 15
                },
                new Painting()
                {
                    Id = 16,
                    Name = "The Vanity Of Knowledge",
                    Description = "A painting in the style of Neo-symbolism. The painting shows classical symbols for knowledge: books and an owl. The hourglass represents the passing of time. But the oil lamp on the left is off and the background consists of a dim landscape. One meaning is that no matter how much one thinks one knows, in the end one knows nothing at all.",
                    Year = 2001,
                    ArtistId = 5,
                    StyleId = 4,
                    ImageId = 16,
                    ThumbnailId = 16
                },
                new Painting()
                {
                    Id = 17,
                    Name = "The Crossroads Where We Joined Ways",
                    Description = "The second painting by the painter Terpen Tijn. The painting shows a crossroads in a forest where two roads meet. The flowers on the sides of the road are in bloom. One meaning is that you go faster alone, but together you get further and things come to growth.",
                    Year = 2002,
                    ArtistId = 5,
                    StyleId = 4,
                    ImageId = 17,
                    ThumbnailId = 17
                },
                new Painting()
                {
                    Id = 18,
                    Name = "I'am Your Elf",
                    Description = "A dream image from the youth of the painter August Auriel. This dream image stayed with him for a long time. Normally letters in dreams are not legible and this painting shows several distorted words. The word elf or elven can also refer to the number eleven. This also symbolizes the 'crazy number' and can be explained as a 'deceptive appearance'. The mischievous elf girl represents the inner troubles of the painter himself.",
                    Year = 2002,
                    ArtistId = 6,
                    StyleId = 4,
                    ImageId = 18,
                    ThumbnailId = 18
                },
                new Painting()
                {
                    Id = 19,
                    Name = "Girl Walking Down The Frozen Stairs",
                    Description = "This painting is a dream image by the painter August Auriel. The girl seems to be completely lost in her own thoughts but is probably happy. It is the middle of the winter and it has snowed. The white landscape has its own aesthetic, but is also emotionally distant and can be potentially dangerous. The subject and theme of this painting is probably (unrequited) love.",
                    Year = 2003,
                    ArtistId = 6,
                    StyleId = 4,
                    ImageId = 19,
                    ThumbnailId = 19
                },
                new Painting()
                {
                    Id = 20,
                    Name = "The Artist's Way, Or: The ill Pierrot",
                    Description = "The painting shows a clown figure dressed in white - the Pierrot - sitting by the side of the road. The road, walls and buildings are grey and show sadness. The painter Byron Backyard wants to convey the message that there is no difference between the artist and a Pierrot. Both are geniuses in a certain way, but they are also sad people who are destined to stay on the fringes of society.",
                    Year = 2004,
                    ArtistId = 7,
                    StyleId = 4,
                    ImageId = 20,
                    ThumbnailId = 20
                },
                new Painting()
                {
                    Id = 21,
                    Name = "Angelica Angelique",
                    Description = "Recognizable figure from the video game 'Summer Games Unlimited'.",
                    Year = 2012,
                    ArtistId = 8,
                    StyleId = 5,
                    ImageId = 21,
                    ThumbnailId = 21
                },
                new Painting()
                {
                    Id = 22,
                    Name = "Caroline Convection",
                    Description = "Known figure located at the grocery shop in the video game 'My Endless Adventures with a Twist'.",
                    Year = 2013,
                    ArtistId = 8,
                    StyleId = 5,
                    ImageId = 22,
                    ThumbnailId = 22
                },
                new Painting()
                {
                    Id = 23,
                    Name = "Princess Pixie",
                    Description = "This is the famous elf figure from the video game 'Matchmaker Mayhem'.",
                    Year = 2014,
                    ArtistId = 8,
                    StyleId = 5,
                    ImageId = 23,
                    ThumbnailId = 23
                },
                new Painting()
                {
                    Id = 24,
                    Name = "Caitlin de Caen",
                    Description = "The good hearted blonde girl from the video game 'Sell Second Hand Cars'.",
                    Year = 2015,
                    ArtistId = 8,
                    StyleId = 5,
                    ImageId = 24,
                    ThumbnailId = 24
                },
                new Painting()
                {
                    Id = 25,
                    Name = "Victoria de la Mer",
                    Description = "The main character of the educational video game 'The Spelling Corrector'.",
                    Year = 2016,
                    ArtistId = 8,
                    StyleId = 5,
                    ImageId = 25,
                    ThumbnailId = 25
                },
            };
        }

    }

}