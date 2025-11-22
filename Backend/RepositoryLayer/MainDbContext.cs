using Microsoft.EntityFrameworkCore;
using RepositoryLayer.DummyData;
using RepositoryLayer.DummyData.Images;
using RepositoryLayer.DummyData.Thumbnails;
using RepositoryLayer.Entities;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class MainDbContext : DbContext
    {

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Style> Styles { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Thumbnail> Thumbnails { get; set; }

        public DbSet<Painting> Paintings { get; set; }

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Add dummy data to the database.
            modelBuilder.Entity<Painting>().HasData(
               DummyDataPaintings.Create()
            );

            modelBuilder.Entity<Artist>().HasData(
                DummyDataArtists.Create()
            );

            modelBuilder.Entity<Style>().HasData(
               DummyDataStyles.Create()
            );

            var allImages = DummyDataImagesPart_001.Create()
                .Concat(DummyDataImagesPart_002.Create())
                .Concat(DummyDataImagesPart_003.Create())
                .Concat(DummyDataImagesPart_004.Create())
                .Concat(DummyDataImagesPart_005.Create())
                .Concat(DummyDataImagesPart_006.Create())
                .Concat(DummyDataImagesPart_007.Create())
                .Concat(DummyDataImagesPart_008.Create())
                .Concat(DummyDataImagesPart_009.Create())
                .Concat(DummyDataImagesPart_010.Create())
                .ToList();

            modelBuilder.Entity<Image>().HasData(
               allImages
            );

            var allThumbnails = DummyDataThumbnailsPart_001.Create()
                .Concat(DummyDataThumbnailsPart_002.Create())
                .Concat(DummyDataThumbnailsPart_003.Create())
                .Concat(DummyDataThumbnailsPart_004.Create())
                .Concat(DummyDataThumbnailsPart_005.Create())
                .Concat(DummyDataThumbnailsPart_006.Create())
                .Concat(DummyDataThumbnailsPart_007.Create())
                .Concat(DummyDataThumbnailsPart_008.Create())
                .Concat(DummyDataThumbnailsPart_009.Create())
                .Concat(DummyDataThumbnailsPart_010.Create())
                .ToList();

            modelBuilder.Entity<Thumbnail>().HasData(
               allThumbnails
            );

        }

    }

}