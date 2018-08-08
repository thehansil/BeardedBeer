using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerTracking_be.Data.Beers;
using MongoCrud.Data;
using MongoCrud.Domain.Beers;

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
    }
}
