using System;
using System.Collections.Generic;
using System.Text;
using MongoCrud.Domain.Breweries;
using MongoDB.Driver;

namespace MongoCrud.Data.Breweries
{
    public class BreweryRepo : BaseRepo<Brewery>
    {
        public BreweryRepo() : base("breweries")
        {
        }
    }
}
