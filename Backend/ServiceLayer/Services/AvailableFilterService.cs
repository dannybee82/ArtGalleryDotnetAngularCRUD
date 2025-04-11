using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using RepositoryLayer.Repository;
using ServiceLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AvailableFilterService : IAvailableFilterService
    {
        private readonly IPaintingRepository _paintingRepository;
        public AvailableFilterService(IPaintingRepository paintingRepository) 
        {
            _paintingRepository = paintingRepository;
        }

        public async Task<FiltersAvailableDto> GetAvailableFilters(FilterDataDto filter)
        {
            try
            {
                IQueryable<Painting> query = _paintingRepository.GetQueryable()
                            .Include(x => x.Artist)
                            .Include(x => x.Style);

                if (filter.Styles != null)
                {
                    if (filter.Styles.Count() > 0)
                    {
                        query = query.Where(x => filter.Styles.Contains(x.Style != null ? x.Style.Id : 0));
                    }
                }

                if (filter.Artists != null)
                {
                    if (filter.Artists.Count() > 0)
                    {
                        query = query.Where(x => filter.Artists.Contains(x.Artist != null ? x.Artist.Id : 0));
                    }
                }

                if (filter.Years != null)
                {
                    if (filter.Years.Count() > 0)
                    {
                        query = query.Where(x => filter.Years.Contains(x.Year));
                    }
                }

                var uniqueStyles = await query.Select(x => x.Style).Distinct().OrderBy(x => x.Name).ToListAsync().ConfigureAwait(false);
                var uniqueArtists = await query.Select(x => x.Artist).Distinct().OrderBy(x => x.Name).ToListAsync().ConfigureAwait(false);
                var uniqueYears = await query.Select(x => x.Year).Distinct().OrderBy(x => x).ToListAsync().ConfigureAwait(false);

                List<int> allStyles = filter.Styles != null ? filter.Styles : new List<int>();
                List<int> allArtists = filter.Artists != null ? filter.Artists : new List<int>();
                List<int> allYears = filter.Years != null ? filter.Years : new List<int>();

                FiltersAvailableDto activeFilters = new FiltersAvailableDto();

                foreach(var style in uniqueStyles)
                {
                    if(style != null)
                    {
                        activeFilters.Styles.Add(new FilterItemDto()
                        {
                            Label = style.Name,
                            Value = style.Id
                        });
                    }                    
                }

                foreach (var artist in uniqueArtists)
                {
                    if(artist != null)
                    {
                        activeFilters.Artists.Add(new FilterItemDto()
                        {
                            Label = artist.Name,
                            Value = artist.Id
                        });
                    }                    
                }

                foreach (var year in uniqueYears)
                {
                    activeFilters.Years.Add(new FilterItemDto()
                    {
                        Label = year.ToString(),
                        Value = year
                    });
                }

                return activeFilters;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

    }

}