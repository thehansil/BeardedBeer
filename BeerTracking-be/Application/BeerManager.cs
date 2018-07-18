using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoCrud.Data;
using MongoCrud.Domain.Beers;

namespace BeerTracking_be.Application
{
    public class BeerManager : BaseManager<Beer>
    {
        public BeerManager(BaseRepo<Beer> repo) : base(repo)
        {
        }
    }
}
