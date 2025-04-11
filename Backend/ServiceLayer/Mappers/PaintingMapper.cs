using RepositoryLayer.Entity;
using ServiceLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mappers
{
    public class PaintingMapper
    {

        public static PaintingDto ToDto(Painting entity)
        {
            PaintingDto dto = new();
            dto.Id = entity.Id;
            dto.Name = entity.Name;
            dto.Description = entity.Description;
            dto.Year = entity.Year;

            if(entity.Artist != null)
            {
                dto.Artist = ArtistMapper.ToDto(entity.Artist);
            }
                        
            if(entity.Style != null) 
            {
                dto.Style = StyleMapper.ToDto(entity.Style);
            }

            if (entity.Image != null)
            {
                dto.Image = ImageMapper.ToDto(entity.Image);
            }

            if (entity.Thumbnail != null)
            {
                dto.Thumbnail = ThumbnailMapper.ToDto(entity.Thumbnail, true);
            }

            return dto;
        }

        public static Painting ToEntity(PaintingDto dto)
        {
            Painting entity = new();

            if (dto.Id != null)
            {
                entity.Id = dto.Id ?? 0;
            }

            entity.Name = dto.Name;
            entity.Description = dto.Description;
            entity.Year = dto.Year;

            if(dto.Artist != null)
            {
                if(dto.Artist.Id != null)
                {
                    entity.ArtistId = dto.Artist.Id ?? 0;
                }
            }

            if(dto.Style != null)
            {
                if(dto.Style.Id != null)
                {
                    entity.StyleId = dto.Style.Id ?? 0;
                }
            }

            if(dto.Thumbnail != null)
            {
                if(dto.Thumbnail.Id != null)
                {
                    entity.ThumbnailId = dto.Thumbnail.Id ?? 0;                    
                }

                if(dto.Thumbnail.ParentImageId != null)
                {
                    entity.ImageId = dto.Thumbnail.ParentImageId;
                }
            }

            return entity;
        }

    }

}