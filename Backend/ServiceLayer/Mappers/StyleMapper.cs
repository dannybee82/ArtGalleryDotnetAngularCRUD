using RepositoryLayer.Entity;
using ServiceLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mappers
{
    public class StyleMapper
    {

        public static StyleDto ToDto(Style entity)
        {
            StyleDto dto = new();
            dto.Id = entity.Id;
            dto.Name = entity.Name;
            dto.Description = entity.Description;

            return dto;
        }

        public static Style ToEntity(StyleDto dto)
        {
            Style entity = new();

            if (dto.Id != null)
            {
                entity.Id = dto.Id ?? 0;
            }
            entity.Name = dto.Name;
            entity.Description = dto.Description;

            return entity;
        }

    }

}