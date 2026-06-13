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
                    Description = "The second painting of Norbert Nikolaus. This painting shows a young woman in a rich floral landscape. It is probably mid-summer. The castle in the background adds an extra element of mystery.",
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
                    Description = "The dominant green and brown color radiate peace and relaxation. The painting shows a girl sitting with her back against a wall. The painter encourages the viewer to think about a moment of rest.",
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
                    Description = "A painting in the style of Neo-symbolism. The painting shows classical symbols of knowledge: books and an owl. The hourglass represents the passing of time. But the oil lamp on the left is off and the background consists of a dim landscape. One meaning is that no matter how much one thinks one knows, in the end one knows nothing at all.",
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
                    Description = "Known figure located at the grocery store in the video game 'My Endless Adventures with a Twist'.",
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
                    Description = "This early painting by artist Pietro Picobello depicts a medieval inn with its lights burning. A lone figure stands outside the inn. It is clearly nighttime, with the full moon illuminating the cloudy sky. This enigmatic setting carries the message of a distant and nostalgic past.",
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
                    Description = "This complex painting features various light and dark effects. Standing upright, a woman in a brown polka-dotted cloak captures the viewer's attention. A ray of light shines on the tower she stands on. The woman points her index finger toward the other tower at the left, a building symbolizing tradition, conservatism and the structure of society. The painting expresses a deep longing for a nostalgic past.",
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
                    Description = "A very mysterious painting depicting a frozen gate. In the center, a mysterious figure in green watches over the gate. Behind the figure is a wooden gate decorated with gilding. On either side of the gate are two statues, whose identities remain unknown. One possible meaning is the relationship between the inner and outer worlds or between sleeping and waking.",
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
                    Description = "The painting depicts the interior of a medieval Gothic cathedral. In the center and foreground there are three mystical figures dressed in white. These figures are the guardians of an equally enigmatic golden relic that depicts a face. The painting is imbued with medieval religious symbolism. One possible meaning is the separation of body and soul.",
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
                new Painting()
                {
                    Id = 41,
                    Name = "The Royal Alchemist tries to make Gold",
                    Description = "The painting depicts an alchemist working at the royal court. Striking are the glass laboratory vials filled with colorful substances. The alchemist is apparently close to making gold, as he holds a glass vial with a radiant golden hue.<BR><BR>While gold symbolizes wealth, success, and achievement, the alchemist symbolizes personal growth and self-discovery. The art critic John Ruskin III Junior was enthusiastic about this painting with its striking colours and deeper meaning.",
                    Year = 2019,
                    ArtistId = 16,
                    StyleId = 9,
                    ImageId = 41,
                    ThumbnailId = 41
                },
                new Painting()
                {
                    Id = 42,
                    Name = "The Royal Archivist delves into the Chronicles",
                    Description = "In the center, the royal archivist is depicted holding a book or chronicle. On either side are bookcases filled with books. The archivist is intently reading and absorbed in his work.<BR><BR>The symbolism of chronicles is the recording of events and the passage of time. On the other hand, the archive symbolizes a collection of memories, history, and forgotten or hidden knowledge. The art critic John Ruskin III Junior praised this painting for its deeper meaning.",
                    Year = 2019,
                    ArtistId = 16,
                    StyleId = 9,
                    ImageId = 42,
                    ThumbnailId = 42
                },
                new Painting()
                {
                    Id = 43,
                    Name = "The Royal Diplomat is out for Business",
                    Description = "At the center of this painting is a diplomat adorned with royal regalia. Diplomats are generally not pleasant individuals, but they are dedicated to conducting business on behalf of those in power.<BR><BR>The royal diplomat symbolizes both the presence and the interests of a country through communication. A relationship is established through negotiation. The art critic John Ruskin III Junior praised this painting for its splendor and regal allure, which captured the world of diplomacy.",
                    Year = 2019,
                    ArtistId = 13,
                    StyleId = 9,
                    ImageId = 43,
                    ThumbnailId = 43
                },
                new Painting()
                {
                    Id = 44,
                    Name = "The Judgment made by the Three Wise Judges at the King's Court",
                    Description = "The painting depicts a wooden table with four golden chalices (wealth, status and sacrifice) and three wise elderly royal judges behind it. The three judges are contemplating the facts and weighing certain cases to arrive at a just verdict. A ray of light falls on the man on the right, casting a long shadow (fate).<BR><BR>The court of justice is a classical symbol of justice and order. The art critic John Ruskin III Junior judged that this painting shows the difficulty of arriving at a just verdict. He even suggested that the painting symbolizes reckoning or divine judgment.",
                    Year = 2019,
                    ArtistId = 15,
                    StyleId = 9,
                    ImageId = 44,
                    ThumbnailId = 44
                },
                new Painting()
                {
                    Id = 45,
                    Name = "The Victorious King",
                    Description = "The central figure of this painting is a king holding both a sword and a red banner. The dominant red color symbolizes war, destruction, and intense energy on the one hand, and bravery, daring, and victory on the other. The castle in the background in this painting symbolizes protection. The sword symbolizes physical strength, worldly power, and decision-making.<BR><BR>The art critic John Ruskin III Junior praised this painting for its ability to capture the spirit of victory. The art critic commissioned this painting and is proud to own it in his private collection.",
                    Year = 2019,
                    ArtistId = 14,
                    StyleId = 9,
                    ImageId = 45,
                    ThumbnailId = 45
                },
                new Painting()
                {
                    Id = 46,
                    Name = "The Revised Spirit of the Summit",
                    Description = "Based on Frederic Leighton's painting \"The Spirit of the Summit\", the artist offers his own revised interpretation. On the mountaintop now sits a modern woman dressed in white, wearing a white pearl necklace, white pearl bracelets, and white high heels. While Leighton's painting conveyed the message that it's \"cold and lonely at the top\", the artist offers a different interpretation: that by reaching the summit, a woman has achieved her fullest potential. In the upper right, the light of a bright star shines on the woman.<BR><BR>Art critic John Ruskin III Junior considered this to be in conflict with the criteria of spectrality, as that is what the title refers to. The artist agreed with this point of criticism and stated that this is more than compensated for by the other two criteria: frigidity (low) and monotonicity (low). The final comment by art critic John Ruskin III Junior was that there is certainly a meaning attached to this painting.",
                    Year = 2002,
                    ArtistId = 1,
                    StyleId = 10,
                    ImageId = 46,
                    ThumbnailId = 46
                },
                new Painting()
                {
                    Id = 47,
                    Name = "Saskia des Esseintes conveys the Message of World Peace",
                    Description = "The woman is dressed in a stunning long white dress with a trail, she is adorned with white pearl jewelry and wearing white high heels. For more elegance and peacefulness, white doves have been added to the painting, where the dove is the classic symbol of peace, as well as beauty, innocence, and hope. Peace, in particular, is a theme that transcends borders, cultures, and religions.<BR><BR>The art critic John Ruskin III Junior praised this painting. Not only does the woman refer to the real world, but she also fulfills the three criteria of Glamour-Estheticism where all scores are low. Moreover, the art critic is an ardent proponent of World Peace and fully endorses its message.",
                    Year = 2003,
                    ArtistId = 2,
                    StyleId = 10,
                    ImageId = 47,
                    ThumbnailId = 47
                },
                new Painting()
                {
                    Id = 48,
                    Name = "Victoria de la Mer in Ancient Egyptian Style",
                    Description = "The painting depicts a beautiful woman with dark hair and brown eyes. A striking feature is the golden necklace with pendant she wears. The pendant, also made of gold and set with reconstructed turquoise stones, hangs from a golden chain. The pendant depicts the face of a woman — most likely the Egyptian goddess Isis, a central Egyptian goddess of magic, motherhood, healing, and protection — with wings on either side. Turquoise symbolizes\r\nharmony, balance, protection, healing, and spiritual communication.<BR><BR>Art critic John Ruskin III Junior, praised this painting. He wrote in a review that: \"This woman is not only a true muse of the Glamour-Estheticism art movement (...) but also fulfills the three criteria of Glamour-Estheticism (...) and the painting is very original\".",
                    Year = 2004,
                    ArtistId = 1,
                    StyleId = 10,
                    ImageId = 48,
                    ThumbnailId = 48
                },
                new Painting()
                {
                    Id = 49,
                    Name = "A Musing Muse on the Terrace",
                    Description = "The painting depicts a woman with brown eyes and brown hair who, while looking at the viewer, is also lost in her own thoughts. A viewer may ask themself: 'What is she thinking about?' The woman wears an asymmetrical dress and a piece of jewelry around her neck and in her hair.<BR><BR>The predominant color the painting is aquamarine: a blend of green and blue. Aquamarine symbolizes tranquility, calmness, and harmony, evoking the serenity of the sea, from which it gets its name. The cup of coffee also refers to connection, sociality, energy, and well-being.<BR><BR>Art critic John Ruskin III Junior criticized this painting as an everyday scene that scored particularly high on the criteria of \"monotonicity.\" The artist countered that it is up to the viewer's imagination to follow the musings of this muse.",
                    Year = 2005,
                    ArtistId = 2,
                    StyleId = 10,
                    ImageId = 49,
                    ThumbnailId = 49
                },
                new Painting()
                {
                    Id = 50,
                    Name = "Perchance a Dream",
                    Description = "A controversial painting that sparked discussion. The painting depicts a beautiful woman in an asymmetrical red dress. Red is the color of radiant energies, the color of life and love, vitality, warmth, and passion. The woman wears an exquisite golden necklace with a golden pendant set with a ruby. The precious ruby ​​symbolizes wealth, power, and protection. It is believed to inspire confidence, courage, and emotional strength in its wearer.<BR><BR>The controversy lies in the title, which refers to a dream state. Art critic John Ruskin III Junior considered this as something that goes against the criteria of spectrality. However, the artist objected that the emphasis should be on \"Perchance\" in the title, claiming that he had seen the woman in the real world but could not remember where and when. According to the artist the woman is a true muse albeit from an alternate reality where everything is in order.",
                    Year = 2006,
                    ArtistId = 2,
                    StyleId = 10,
                    ImageId = 50,
                    ThumbnailId = 50
                },
                new Painting()
                {
                    Id = 51,
                    Name = "The Elder of Might and Magic",
                    Description = "An indigenous elder with a white beard stands as a beacon of ancient wisdom, draped in rich green garments that echo the forests surrounding him. In his weathered hand, he grips a magnificent staff crowned with a dragon — a symbol of passion tempered by self-control. Behind him, verdant hills roll gently with some trees, while a majestic mountain rises in the distance, anchoring the composition with timeless grandeur.<BR><BR>The dragon atop the staff represents the duality of passion and restraint, while the elder himself embodies wisdom, guidance, and the preservation of traditional values passed down through generations.<BR><BR>The art critic John Ruskin III Junior praised this painting: \"(...) A striking work that captures the indigenous spirit with remarkable authenticity. The painting radiates an engaging energy, with the elder's presence commanding respect and the dragon staff serving as a powerful focal point. An interesting and culturally resonant piece that celebrates ancestral knowledge.\"",
                    Year = 2007,
                    ArtistId = 17,
                    StyleId = 11,
                    ImageId = 51,
                    ThumbnailId = 51
                },
                new Painting()
                {
                    Id = 52,
                    Name = "Queen of the Tropical Sea",
                    Description = "An indigenous woman of regal bearing adorns herself with exquisite jewelry—delicate earrings catching the light, an ornate necklace draped across her chest, and an intricately crafted waist belt that speaks of her sovereignty. Her unique headpiece, infused with exotic flair, crowns her with an air of mystique. Her clothing displays intricate patterns woven in soft light blue, pristine white, and warm beige tones. Behind her, the sea rises in dynamic waves, suggesting both movement and the eternal rhythm of the ocean.<BR><BR>The queen represents intuition and personal growth, while the sea symbolizes the profound connection between the conscious and subconscious mind, the visible and hidden depths of the self.<BR><BR>The painting has been positively received by the art critic John Ruskin III Junior who stated: \"(...) A striking composition with an exotic vibe that captivates the viewer. You can almost feel the waves of the sea emanating from the canvas. The indigenous queen is rendered beautifully, her jewelry and clothing creating a harmonious visual symphony that celebrates both elegance and cultural richness.\"",
                    Year = 2007,
                    ArtistId = 17,
                    StyleId = 11,
                    ImageId = 52,
                    ThumbnailId = 52
                },
                new Painting()
                {
                    Id = 53,
                    Name = "The Eye of the Griffin",
                    Description = "A sorceress draped in a purple dress, her dark hair cascading around her shoulders, commands the center of this enigmatic composition. Her form glimmers with exquisite jewelry—ornamental pieces adorning her hair, an elegant necklace, and delicate bracelets that catch the eye. To her left, a magnificent griffin — a fantasy creature of immense presence — stands as her companion and guardian. Above her hand hovers a sparkling diamond, radiating clarity and inner light. Behind her, the weathered ruins of an ancient temple rise from the mists, evoking the mysteries of antiquity.<BR><BR>The sorceress symbolizes the refinement of one's skills and inner power, the griffin represents immense power, courage, and protection, while the sparkling diamond embodies clarity and enlightenment.<BR><BR>The art critic John Ruskin III Junior praised this painting. He wrote in his review: \"(...) An enigmatic and original painting that draws the viewer into its mystical world. The sparkling diamond is particularly striking, standing out brilliantly against the composition and serving as a focal point of spiritual clarity. (...) The interplay between the sorceress, griffin, and ancient temple creates a compelling narrative of power and wisdom.\"",
                    Year = 2007,
                    ArtistId = 17,
                    StyleId = 11,
                    ImageId = 53,
                    ThumbnailId = 53
                },
                new Painting()
                {
                    Id = 54,
                    Name = "The Seeress Digs Into Memories",
                    Description = "At the center of this mystical composition stands a Seeress clothed in deep blue garments, her form adorned with luminous golden jewelry—ornamental pieces woven through her hair, encircling her neck, adorning the upper portion of her dress, and gracing her wrists as bracelets. Before her, a rotating golden triskelion spirals with ancient power and symbolism. The background dissolves into an enigmatic abstract realm of deep blue tones, punctuated by geometric cubes that suggest dimensions beyond ordinary perception.<BR><BR>The Seeress embodies vision and spiritual guidance, while the triskelion carries powerful, positive symbolism representing personal growth, transformation, and the eternal cycle of becoming.<BR><BR>The art critic John Ruskin III Junior was positive about this painting and wrote in his review: \"(...) An excellent exploration of color and form. The deep blue palette creates a mystical and mysterious atmosphere that is both captivating and introspective. (...) The non-eurocentric approach to the subject matter is refreshing and culturally significant. The rotating triskelion and abstract background work in harmony to create a truly transcendent painting.\"",
                    Year = 2007,
                    ArtistId = 17,
                    StyleId = 11,
                    ImageId = 54,
                    ThumbnailId = 54
                },
                new Painting()
                {
                    Id = 55,
                    Name = "Of Past and Present Times",
                    Description = "A sorceress in a striking purple dress, her dark hair framing her face with mysterious allure, stands as a bridge between epochs. She is adorned with exquisite exotic golden jewelry—ornate earrings, an elaborate necklace, and intricate bracelets that speak of timeless elegance. Mysterious light blue clouds swirl around her legs, ethereal and dreamlike. In her hand, she cradles a luminous sphere that glows with inner radiance, casting soft light across her form. Behind her, the majestic ruins of an ancient temple emerge from the shadows, their weathered stones speaking of spirituality and the passage of ages.<BR><BR>The sorceress symbolizes transformation and the evolution of ambitions through time, the temple represents deep spirituality and the yearning for inner peace, while the luminous sphere embodies profound inner clarity and spiritual enlightenment.<BR><BR>The art critic John Ruskin III Junior considered this painting as the pinnacle of Mystical Mirageism. Het stated: \"(...) A truly enigmatic painting that masterfully weaves together past and present. The mysterious temple from antiquity provides a haunting backdrop, while the striking light blue clouds and luminous sphere create a sense of otherworldly beauty and spiritual depth. (...) The composition is both mysterious and illuminating, inviting contemplation on the nature of transformation and enlightenment.\"",
                    Year = 2007,
                    ArtistId = 17,
                    StyleId = 11,
                    ImageId = 55,
                    ThumbnailId = 55
                },
                new Painting()
                {
                    Id = 56,
                    Name = "The Radiant Golden Key of the Universe",
                    Description = "At the center of this composition is a radiant golden key, its surface luminous and commanding attention. The key is surrounded by a constellation of stars that seem to orbit around it like planets around a sun. The background is ethereal and nebulous, filled with cosmic imagery that suggests infinite space and possibility. The key itself appears ancient, its unusual design raising questions about its origin and purpose. Viewers are naturally drawn to contemplate which lock this mysterious key might unlock.<br><br>The key represents transition, revelation, and inner freedom — the instrument through which barriers are overcome and new realms accessed. The cosmos symbolizes ordered wholeness and the infinite potential of existence. However, the lock, though absent from the composition, remains a deeply layered symbol that balances protection and restriction, suggesting that access to knowledge and transformation comes with both liberation and constraint. Together, these elements explore humanity's eternal quest to unlock the mysteries of existence.<br><br>The art critic John Ruskin III Junior has acknowledged the distinctive use of bright, radiant colors that distinguish this work from others in the movement. However, they have ultimately concluded that the artwork, like the entire Cosmic Etherialism movement, is devoid of any genuine meaning or artistic substance. The composition has been criticized as more suitable for a science fiction magazine cover than for serious artistic consideration, suggesting that its appeal is primarily visual and commercial rather than intellectually or emotionally profound.",
                    Year = 2020,
                    ArtistId = 18,
                    StyleId = 12,
                    ImageId = 56,
                    ThumbnailId = 56
                },
                new Painting()
                {
                    Id = 57,
                    Name = "A Portal to Another Dimension",
                    Description = "This large-format artwork depicts an ancient portal standing open, its archway framing a passage to unknown realms. Through the opening, a swirling cloud formation dominates the view, suggesting turbulent transformation and cosmic energy. A bright sphere of light appears in the upper right and at the bottom of the composition, creating focal points that guide the viewer's gaze through the portal. The portal itself features antique columns adorned with various ornaments and classical details, grounding the fantastical imagery in historical architectural tradition. The overall composition suggests both invitation and warning, drawing viewers toward the threshold while maintaining a sense of mystery.<br><br>A portal in space symbolizes the ultimate threshold between the known and the unknown, representing the boundary where human understanding reaches its limits. It embodies transition and profound metamorphosis, suggesting that passage through such a threshold fundamentally transforms those who dare to cross it. The portal reflects humanity's deep desire to transcend physical limitations and access higher states of consciousness or alternate realities, speaking to our eternal yearning for expansion beyond the material world. The classical architectural elements suggest that this transcendence is not new but rather a timeless human aspiration.<br><br>The art critic John Ruskin III Junior was moderately positive about this artwork, recognizing that it distinguished itself from other works in the movement through greater attention to detail and compositional sophistication. The critic appreciated the more developed visual language and the apparent effort to create a coherent artistic vision. However, even this more favorable assessment was tempered by the critic's inability to discover a possible deeper meaning in the work, suggesting that even the movement's more accomplished pieces ultimately fail to achieve genuine conceptual depth.",
                    Year = 2020,
                    ArtistId = 19,
                    StyleId = 12,
                    ImageId = 57,
                    ThumbnailId = 57
                },
                new Painting()
                {
                    Id = 58,
                    Name = "Ascending to the Stars",
                    Description = "This artwork is rendered in very bright, luminous light colors that create an almost blinding radiance throughout the composition. A figure is visible at the bottom center, though its gender remains ambiguous — it could be male or female, human or something more ethereal. This central figure is surrounded by and rendered in equally bright golden colors that seem to emanate from within. The background is dominated by the cosmos, filled with numerous stars that create a sense of infinite space and possibility. The overall effect is one of transcendence and spiritual elevation.<br><br>The symbolism of ascending centers on transcendence, spiritual growth, and the human desire to connect with something greater than oneself. It represents the rising above the material world to attain higher knowledge, enlightenment, and inner liberation, reflecting a fundamental shift from an unconscious, unaware existence to a fully conscious, awakened state. Stars symbolize hope, joy, protection, guidance, and destiny, suggesting that the ascending figure moves toward a predetermined cosmic purpose. Together, these elements celebrate the human potential for spiritual evolution and cosmic connection.<br><br>The art critic John Ruskin III Junior was moderately positive about this artwork, primarily due to the striking and distinctive use of bright colors that create visual impact. However, the assessment was qualified by significant reservations about the composition's limited visual elements and the overly suggestive nature of the title. The critic felt that the title imposed meaning rather than allowing it to emerge organically from the visual elements. Moreover, the critic concluded that no further meaning could be discovered beyond the surface-level suggestion of spiritual ascension, limiting the work's intellectual and artistic significance.",
                    Year = 2021,
                    ArtistId = 20,
                    StyleId = 12,
                    ImageId = 58,
                    ThumbnailId = 58
                },
                new Painting()
                {
                    Id = 59,
                    Name = "The Cosmos Captured in a Jar",
                    Description = "In the center of this composition stands a small jar containing a microcosmos of the universe: a moon, stars, and ethereal clouds swirl within the transparent glass. In the background, other moons, planets, and stars are visible, suggesting that the jar contains only a fragment of a much larger cosmic whole. The jar stands on the ground where small spheres of various colors and other luminous stars lie scattered, creating a sense of cosmic abundance and overflow. The contrast between the contained cosmos within the jar and the infinite cosmos surrounding it creates a paradoxical meditation on scale and perspective.<br><br>Jars universally symbolize a vessel for containment, transformation, and preservation, serving as repositories for both tangible and intangible resources. Because of their capacity to hold and protect, jars often represent the human body, motherhood, the ego, or the divine—containers of essence and meaning. The cosmos or universe within the jar represents ordered wholeness, suggesting that infinity can be captured, preserved, and contemplated in miniature. Together, these elements explore the relationship between the infinite and the finite, the universal and the particular, suggesting that all of existence can be found reflected in small, intimate spaces.<br><br>The art critic John Ruskin III Junior was moderately positive about this artwork, recognizing its originality and unusual approach to the themes of the movement. The critic appreciated the bright colors and found the title interesting and evocative. However, the assessment remained qualified by uncertainty about deeper meaning — the critic acknowledged that while a deeper meaning is not immediately clear, it cannot be entirely ruled out either. This ambivalent reception suggests a work that achieves some success in creating visual interest and conceptual intrigue, even if it ultimately resists definitive interpretation.",
                    Year = 2020,
                    ArtistId = 21,
                    StyleId = 12,
                    ImageId = 59,
                    ThumbnailId = 59
                },
                new Painting()
                {
                    Id = 60,
                    Name = "A Cosmic Library and Apocrypha",
                    Description = "On the left and right sides of this composition, straight bookcases filled with books create architectural frames that organize the space. More toward the center, bookcases spiral in repeating patterns, creating a sense of infinite recursion and labyrinthine complexity. Above, in the hazy blue sky, various open books swirl and float, their pages seeming to catch cosmic winds. At the bottom center stands a solitary figure, rendered only as an outline visible under white light, suggesting introspection and contemplation. The overall composition creates a sense of vast knowledge surrounding a small, isolated consciousness.<br><br>A library symbolizes the preservation of human memory, the structured architecture of the human mind, and the infinite pursuit of knowledge and understanding. The cosmos or universe represents ordered wholeness, suggesting that knowledge itself is cosmic in scope and significance. A book is a multifaceted symbol representing knowledge, wisdom, learning, and the human journey of transformation—each volume a record of human experience and aspiration. The solitary figure at the center suggests that despite the vastness of accumulated knowledge, the individual consciousness remains isolated and must undertake its own journey of discovery and meaning-making. Together, these elements explore the relationship between individual consciousness and collective human knowledge.<br><br>The art critic John Ruskin III Junior was complimentary about this painting, appreciating the various visual elements that clearly carry symbolic meaning and contribute to a coherent artistic vision. The critic recognized the sophistication of the composition and the intentionality behind each element. However, the assessment was tempered by criticism of the hazy use of color, which the critic felt detracts from the clarity and impact of the meaning. The solitary figure at the bottom center was judged positively, with the critic attributing to it the meaning of introspection and self-reflection. Overall, this work was recognized as one of the movement's more successful attempts at meaningful artistic expression, even if imperfectly realized.",
                    Year = 2021,
                    ArtistId = 22,
                    StyleId = 12,
                    ImageId = 60,
                    ThumbnailId = 60
                },
            };
        }

    }

}