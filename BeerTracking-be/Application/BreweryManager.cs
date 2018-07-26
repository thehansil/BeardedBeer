using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoCrud.Data;
using MongoCrud.Data.Breweries;
using MongoCrud.Domain.Breweries;

namespace BeerTracking_be.Application
{
    public class BreweryManager : BaseManager<Brewery>
    {
        BreweryRepo repo;
        public BreweryManager(BaseRepo<Brewery> repo) : base(repo)
        {
            this.repo = repo as BreweryRepo;
        }

        public List<Brewery> GetbyState(string state)
        {
            List<Brewery> allBreweries = repo.ListAll();
            return allBreweries.Where(a => a.Locations.Any(b => b.State == state)).ToList();
        }
    }
}
