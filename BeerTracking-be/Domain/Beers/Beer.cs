using System;
using System.Collections.Generic;
using MongoCrud.Data.Breweries;

namespace MongoCrud.Domain.Beers
{
    public class Beer : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Abv { get; set; }
        public bool Domestic { get; set; }
        public bool? ThumbsUp { get; set; }
        public Guid BreweryId { get; set; }
        public List<Guid> LocationIds { get; set; }
        public List<string> Tags { get; set; }
        public Prices Price { get; set; }
        public int Volume { get; set; }
    }
}