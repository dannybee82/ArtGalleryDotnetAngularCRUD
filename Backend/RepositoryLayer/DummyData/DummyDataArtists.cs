using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.DummyData
{
    public class DummyDataArtists
    {

        public static List<Artist> Create()
        {
            return new List<Artist>()
            {
                new Artist() 
                { 
                    Id = 1, 
                    Name = "Jean Millet",
                    Description = "Known for his enigmatic style, the painter's work captures a mysterious essence, blending photographic precision with colorful palettes. His rich compositions invite viewers into a world of playful imagination and hidden meanings.",
                    YearOfBirth = 1972,
                    YearOfDeath = null
                },
                new Artist()
                {
                    Id = 2,
                    Name = "Norbert Nikolaus",
                    Description = "As a pupil of Jean Millet, Norbert Nikolaus would adopt the style of his master. The themes of his paintings are the same: a colourful flower landscape with captivating women. His enigmatic paintings often contain hidden meanings.",
                    YearOfBirth = 1974,
                    YearOfDeath = null
                },
                new Artist()
                {
                    Id = 3,
                    Name = "Dolores Abernathy",
                    Description = "This artist's mysterious background is reflected in her enigmatic paintings, where colorful strokes meet photographic detail. Each piece tells a rich story, balancing playful creativity with profound depth.",
                    YearOfBirth = 1987,
                    YearOfDeath = null
                },
                new Artist()
                {
                    Id = 4,
                    Name = "Gabriel Gale",
                    Description = "A mysterious figure in the art world, this painter's enigmatic works combine colorful vibrancy with photographic realism. Their rich imagination and playful approach redefine traditional artistic boundaries. His untimely death brought an abrupt end to his prosperous career.",
                    YearOfBirth = 1960,
                    YearOfDeath = 2001
                },
                new Artist()
                {
                    Id = 5,
                    Name = "Terpen Tijn",
                    Description = "A versatile artist who has used multiple styles during his career. His paintings are dreamlike and deal with the realm of dream and fantasy. His paintings encourage the viewer to meditate and to transcend the material.",
                    YearOfBirth = 1980,
                    YearOfDeath = null
                },
                new Artist()
                {
                    Id = 6,
                    Name = "August Auriel",
                    Description = "An artist who left the academy of fine arts due to dissatisfaction. Shortly after, he came into contact with the art movement of Neo-Symbolism. His works of art know how to move the viewer emotionally and transcend the material.",
                    YearOfBirth = 1979,
                    YearOfDeath = null
                },
                new Artist()
                {
                    Id = 7,
                    Name = "Byron Backyard",
                    Description = "An artist who initially started in Surrealism. But because he could not find himself in this movement, he went back to Neo-Symbolism. The artist Byron Backyard has a recognizable color palette with the colors: light blue, gray and white. His works manage to capture a dream state.",
                    YearOfBirth = 1981,
                    YearOfDeath = null
                },
                new Artist()
                {
                    Id = 8,
                    Name = "Relm Arrowny",
                    Description = "With a photographic eye for detail, the painter creates colorful masterpieces that feel both enigmatic and mysterious. His rich use of texture and playful themes captivates audiences worldwide.",
                    YearOfBirth = 1994,
                    YearOfDeath = null
                },
                new Artist()
                {
                    Id = 9,
                    Name = "Édouard Marceau",
                    Description = "Édouard Marceau is an ardent reader of fantasy books, and he uses this passion in his paintings. His paintings are captivating and striking, featuring impossible scenes placed within a real-world setting. Recurring themes include: beaches, seals, and extraordinary figures.",
                    YearOfBirth = 1995,
                    YearOfDeath = null
                },
                new Artist()
                {
                    Id = 10,
                    Name = "Lucien Delacroix",
                    Description = "Lucien Delacroix has been trained as a draftsman. After working as a desktop publisher for a few years, he grew bored. He recently rediscovered his passion for black-and-white drawing. His drawings are striking and explore diverse themes.",
                    YearOfBirth = 1995,
                    YearOfDeath = null
                },
                new Artist()
                {
                    Id = 11,
                    Name = "Cédric Fournier",
                    Description = "One of Cédric Fournier's hobbies is birdwatching. Not surprisingly, his paintings depict birds, but these are drawn from the realm of fantasy. His artwork appeals primarily to other birdwatchers and bird enthusiasts.",
                    YearOfBirth = 1995,
                    YearOfDeath = null
                },
                new Artist()
                {
                    Id = 12,
                    Name = "Mario Dufresne",
                    Description = "Mario Dufresne's artworks initially appear to address worldly themes. However, upon closer inspection, viewers discover impossible scenes. Mario Dufresne was the artist who saw fit to adopt the term \"Old School Revivalism\" from art critic John Ruskin III Junior.",
                    YearOfBirth = 1996,
                    YearOfDeath = null
                },
            };
        }

    }

}
