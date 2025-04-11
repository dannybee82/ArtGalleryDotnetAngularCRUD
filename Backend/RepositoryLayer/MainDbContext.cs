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

            var allImages = DummyDataImagesPart1.Create()
                .Concat(DummyDataImagesPart2.Create())
                .Concat(DummyDataImagesPart3.Create())
                .Concat(DummyDataImagesPart4.Create())
                .Concat(DummyDataImagesPart5.Create())
                .ToList();

            modelBuilder.Entity<Image>().HasData(
               allImages
            );

            var allThumbnails = DummyDataThumbnailsPart1.Create()
                .Concat(DummyDataThumbnailsPart2.Create())
                .Concat(DummyDataThumbnailsPart3.Create())
                .Concat(DummyDataThumbnailsPart4.Create())
                .Concat(DummyDataThumbnailsPart5.Create())
                .ToList();

            modelBuilder.Entity<Thumbnail>().HasData(
               allThumbnails
            );

        }

    }

}