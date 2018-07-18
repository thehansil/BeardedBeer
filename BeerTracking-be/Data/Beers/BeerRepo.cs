using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoCrud.Data;
using MongoCrud.Domain.Beers;

namespace BeerTracking_be.Data.Beers
{
    public class BeerRepo : BaseRepo<Beer>
    {
        public BeerRepo() : base("beers")
        {
        }
    }
}
