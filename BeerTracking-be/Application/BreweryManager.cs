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
        public BreweryManager(BaseRepo<Brewery> repo) : base(repo)
        {
        }
    }
}
