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
                new Painting()
                {
                    Id = 26,
                    Name = "The Seals on the Beach",
                    Description = "This painting depicts a beach scene with three seals on the beach. But the viewer's eye is drawn to a woman in a purple dress with a long train floating in the air. The seal on the right seems to notice this female figure. The art critic John Ruskin III Junior noted that \"a meaning is lacking\" and that \"fantasy scenes have been painted before.\" His final judgment is that there is nothing new within the \"Old School Revivalism\" movement.",
                    Year = 2016,
                    ArtistId = 9,
                    StyleId = 6,
                    ImageId = 26,
                    ThumbnailId = 26
                },
                new Painting()
                {
                    Id = 27,
                    Name = "Angel hugging a Baby Seal",
                    Description = "The painting is dominated by a crouching angel figure. She holds a cute small fluffy baby seal in her arms. The smile on the angel's face leaves the viewer guessing. Will the angel put the baby seal back on the ice or take it upwards into heaven? The art critic John Ruskin III Junior, considered this a \"naive depiction\" and that \"angelic figures have been painted often enough.\" It is unclear what meaning the painter is trying to convey with this painting.",
                    Year = 2017,
                    ArtistId = 9,
                    StyleId = 6,
                    ImageId = 27,
                    ThumbnailId = 27
                },
                new Painting()
                {
                    Id = 28,
                    Name = "The Fair Queen",
                    Description = "This large drawing by Lucien Delacroix is ​​titled \"The Fair Queen.\" The artwork is in black and white, a style familiar to the artist. The drawing depicts a woman with various jewelry in her hair, ears, and upon her chest. The background is likely a stained-glass window. Art critic John Ruskin III Junior stated that \"this work is devoid of meaning\" and considered it \"only a mere image from a naive fantasy realm common to the Old School Revivalism movement\".",
                    Year = 2016,
                    ArtistId = 10,
                    StyleId = 6,
                    ImageId = 28,
                    ThumbnailId = 28
                },
                new Painting()
                {
                    Id = 29,
                    Name = "Four Elemental Birds",
                    Description = "In this painting, artist Cédric Fournier depicts four birds representing the four elements — air, earth, fire, and water. The birds depicted are drawn from the realm of fantasy. Art critic John Ruskin III Junior has a negative opinion of this artwork, arguing that \"the four elements are sufficiently incorporated into Renaissance art\" and therefore \"this work of art is nothing special.\"",
                    Year = 2016,
                    ArtistId = 11,
                    StyleId = 6,
                    ImageId = 29,
                    ThumbnailId = 29
                },
                new Painting()
                {
                    Id = 30,
                    Name = "Beyond the Mirror",
                    Description = "This painting depicts a woman and a man in a corridor and appears to be a worldly scene. But the viewer's attention is quickly drawn to the mirror in the woman's hand. Where is her reflection? And to whom is she actually holding a mirror? An additional mystical dimension is added by the fact that both figures are dressed in white and there are candles in the corridor. One possible meaning is that truth lies beyond the mirror, but most people would not dare to go that far and stay focused on the reflection in the mirror. This is the only painting from the \"Old School Revivalism\" movement that art critic John Ruskin III Junior praised for its \"possible meaning.\"",
                    Year = 2017,
                    ArtistId = 12,
                    StyleId = 6,
                    ImageId = 30,
                    ThumbnailId = 30
                },
                new Painting()
                {
                    Id = 31,
                    Name = "Woman taking care of the Sapplings",
                    Description = "This painting with a medieval atmosphere depicts a woman crouched down and tending young trees. The painting conveys the hope that the trees will soon grow larger. The bucket symbolizes capacity and growth over time—and the growth of the small trees is here depicted as more mysterious.",
                    Year = 2018,
                    ArtistId = 13,
                    StyleId = 7,
                    ImageId = 31,
                    ThumbnailId = 31
                },
                new Painting()
                {
                    Id = 32,
                    Name = "A Religious Ceremony",
                    Description = "The painting depicts a medieval religious ceremony in which the four figures are dressed in white. The candles are the classical symbol of light and the continuity of life, death and rebirth. The enigmatic religious ceremony exudes a longing for the past.",
                    Year = 2019,
                    ArtistId = 13,
                    StyleId = 7,
                    ImageId = 32,
                    ThumbnailId = 32
                },
                new Painting()
                {
                    Id = 33,
                    Name = "A Medieval inn under the Full Moon",
                    Description = "An early painting by artist Pietro Picobello depicts a medieval inn with its lights burning. A lone figure stands outside the inn. It is clearly nighttime, with the full moon illuminating the cloudy sky. This enigmatic setting carries the message of a distant and nostalgic past.",
                    Year = 2018,
                    ArtistId = 14,
                    StyleId = 7,
                    ImageId = 33,
                    ThumbnailId = 33
                },
                new Painting()
                {
                    Id = 34,
                    Name = "The Happiness of the People",
                    Description = "The painting depicts a small festival of the common people in a village. At the center are a man and a woman dancing and having fun. The bystanders clap with their hands and are perhaps singing along. The chickens in the foreground are the classic symbol of fertility and motherhood. The painting can be interpreted as a glorification of the Middle Ages.",
                    Year = 2019,
                    ArtistId = 15,
                    StyleId = 7,
                    ImageId = 34,
                    ThumbnailId = 34
                },
                new Painting()
                {
                    Id = 35,
                    Name = "Woman directing a Ray of Light",
                    Description = "This complex painting features various light and dark effects. Standing upright, a woman in a brown polka-dotted cloak captures the viewer's attention. A ray of light shines on the tower she stands on. The woman points her index finger toward the tower, a building symbolizing tradition, conservatism and the structure of society. The painting expresses a deep longing for a nostalgic past.",
                    Year = 2018,
                    ArtistId = 16,
                    StyleId = 7,
                    ImageId = 35,
                    ThumbnailId = 35
                },
                new Painting()
                {
                    Id = 36,
                    Name = "The Village's Seer",
                    Description = "The painting depicts a learned woman with knowledge of the past, present and future. Not only common folk, but also the nobility sought her advice and assistance. The open book is a classic symbol of wisdom. This painting is enigmatic and mysterious, enhanced by the fantasy-like castle visible through the window.",
                    Year = 2018,
                    ArtistId = 13,
                    StyleId = 8,
                    ImageId = 36,
                    ThumbnailId = 36
                },
                new Painting()
                {
                    Id = 37,
                    Name = "The Queen's Royal Healer",
                    Description = "The painting depicts an iterant monk-healer placing both hands on a queen's head. The monk is trying to heal her. The queen's head is slightly bowed and her hands are clasped. Although the queen possesses considerable material wealth, the monk-healer attends to her spiritual needs.",
                    Year = 2019,
                    ArtistId = 16,
                    StyleId = 8,
                    ImageId = 37,
                    ThumbnailId = 37
                },
                new Painting()
                {
                    Id = 38,
                    Name = "The Gate of Remembrance",
                    Description = "A very mysterious painting depicting a frozen gate. In the center, a mysterious figure in green watches over the gate. Behind the figure is a wooden gate decorated with gilding. On either side of the gate are two statues, whose identities remain unknown. One possible meaning is the relationship between the inner and outer worlds, or between sleeping and waking.",
                    Year = 2018,
                    ArtistId = 15,
                    StyleId = 8,
                    ImageId = 38,
                    ThumbnailId = 38
                },
                new Painting()
                {
                    Id = 39,
                    Name = "The Keepers of the Golden Artifact",
                    Description = "The painting depicts the interior of a medieval Gothic cathedral. In the center and foreground are three mystical figures dressed in white. These figures are the guardians of an equally enigmatic golden relic that depicts a face. The painting is imbued with medieval religious symbolism. One possible meaning is the separation of body and soul.",
                    Year = 2019,
                    ArtistId = 13,
                    StyleId = 8,
                    ImageId = 39,
                    ThumbnailId = 39
                },
                new Painting()
                {
                    Id = 40,
                    Name = "Exotic Princess with the Amulet of Light",
                    Description = "A painting with a medieval and exotic setting. There is in the center a princess sitting in a room decorated with various carpets. Various gold objects lie on the floor and the carpets are adorned with rich patterns. In front of the princess stands a treasure chest containing even more gold. In her hand she holds a luminous amulet. She looks somewhat amazed and sees something the viewer doesn't see. Perhaps she realizes that despite her material wealth, she is missing something spiritually.",
                    Year = 2018,
                    ArtistId = 17,
                    StyleId = 8,
                    ImageId = 40,
                    ThumbnailId = 40
                },
            };
        }

    }

}