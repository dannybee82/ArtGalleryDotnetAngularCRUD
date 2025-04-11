using RepositoryLayer.Entity;
using ServiceLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mappers
{
    public class ThumbnailMapper
    {

        public static ThumbnailDto ToDto(Thumbnail entity, bool hideDetails)
        {
            ThumbnailDto dto = new();
            dto.Id = entity.Id;
            dto.Base64 = entity.Base64;

            if(!hideDetails && entity.ParentImageId != null)
            {
                dto.ParentImageId = entity.ParentImageId;
            }

            return dto;
        }

        public static Thumbnail ToEntity(ThumbnailDto dto)
        {
            Thumbnail entity = new();

            if (dto.Id != null)
            {
                entity.Id = dto.Id ?? 0;
            }
            entity.Base64 = dto.Base64;

            if(dto.ParentImageId != null)
            {
                entity.ParentImageId = dto.ParentImageId;
            }

            return entity;
        }

    }

}