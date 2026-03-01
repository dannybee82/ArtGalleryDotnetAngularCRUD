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
        private readonly IStyleRepository _styleRepository;

        public AvailableFilterService(
            IPaintingRepository paintingRepository,
            IStyleRepository styleRepository) 
        {
            _paintingRepository = paintingRepository;
            _styleRepository = styleRepository;
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

                // March 2026 changes: commented out sections below to keep available filters.
                //if (filter.Artists != null)
                //{
                //    if (filter.Artists.Count() > 0)
                //    {
                //        query = query.Where(x => filter.Artists.Contains(x.Artist != null ? x.Artist.Id : 0));
                //    }
                //}

                //if (filter.Years != null)
                //{
                //    if (filter.Years.Count() > 0)
                //    {
                //        query = query.Where(x => filter.Years.Contains(x.Year));
                //    }
                //}

                // March 2026 changes: Keep all styles, then get unique artists and years.
                var allStyles = await _styleRepository.GetAll();
                var uniqueArtists = await query.Select(x => x.Artist).Distinct().OrderBy(x => x.Name).ToListAsync().ConfigureAwait(false);
                var uniqueYears = await query.Select(x => x.Year).Distinct().OrderBy(x => x).ToListAsync().ConfigureAwait(false);

                FiltersAvailableDto activeFilters = new FiltersAvailableDto();

                foreach(var style in allStyles)
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