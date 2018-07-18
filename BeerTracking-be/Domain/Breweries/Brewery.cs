using System;
using System.Collections.Generic;
using System.Text;

namespace MongoCrud.Domain.Breweries
{
    public class Brewery : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ThumbnailUrl { get; set; }
        public List<Location> Locations { get; set; }

        public string StringId
        {
            get => Id.ToString();
            set { }
        }

        public Brewery(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
