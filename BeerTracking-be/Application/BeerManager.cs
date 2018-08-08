using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerTracking_be.Data.Beers;
using MongoCrud.Data;
using MongoCrud.Domain.Beers;
using MongoCrud.Domain.Breweries;

namespace BeerTracking_be.Application
{
    public class BeerManager : BaseManager<Beer>
    {
        private readonly BeerRepo beerRepo;
        public BeerManager(BaseRepo<Beer> repo) : base(repo)
        {
            this.beerRepo = repo as BeerRepo;
        }

        public Beer FindBeerByName(string name)
        {
           return beerRepo.GetAll().Where(a => a.Name == name).FirstOrDefault();
        }

        public List<Beer> GetBeersWithTags(IEnumerable<string> tags)
        {
            return beerRepo.GetAll().Where(w => w.Tags.Any(x => tags.Any(y => x == y))).ToList();
        }

        public List<Beer> GetAllBeersAtBrewery(Brewery brewery)
        {
            return beerRepo.GetAll().Where(w => w.LocationIds.Contains(brewery.Id)).ToList();
        }

        public List<Beer> GetAllBeersByBrewery(Guid id)
        {
            return beerRepo.GetAll().Where(w => w.LocationIds.Contains(id)).ToList();
        }
    }
}
