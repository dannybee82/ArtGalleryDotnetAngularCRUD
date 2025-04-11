using RepositoryLayer.Entities;
using ServiceLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mappers
{
    public class ArtistMapper
    {

        public static ArtistDto ToDto(Artist entity)
        {
            ArtistDto dto = new();
            dto.Id = entity.Id;
            dto.Name = entity.Name;
            dto.Description = entity.Description;
            dto.YearOfBirth = entity.YearOfBirth;

            if(entity.YearOfDeath != null)
            {
                dto.YearOfDeath = entity.YearOfDeath;
            }

            return dto;
        }

        public static Artist ToEntity(ArtistDto dto)
        {
            Artist entity = new();

            if (dto.Id != null)
            {
                entity.Id = dto.Id ?? 0;
            }
            entity.Name = dto.Name;
            entity.Description = dto.Description;
            entity.YearOfBirth = dto.YearOfBirth;
            entity.YearOfDeath = dto.YearOfDeath != null ? dto.YearOfDeath : null;

            return entity;
        }

    }

}
