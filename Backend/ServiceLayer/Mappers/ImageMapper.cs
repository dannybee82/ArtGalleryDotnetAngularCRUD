using RepositoryLayer.Entity;
using ServiceLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mappers
{
    public class ImageMapper
    {

        public static ImageDto ToDto(Image entity)
        {
            ImageDto dto = new();
            dto.Id = entity.Id;
            dto.Base64 = entity.Base64;

            return dto;
        }

        public static Image ToEntity(ImageDto dto)
        {
            Image entity = new();

            if (dto.Id != null)
            {
                entity.Id = dto.Id ?? 0;
            }
            entity.Base64 = dto.Base64;

            return entity;
        }

    }

}