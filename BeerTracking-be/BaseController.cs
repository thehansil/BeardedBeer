using System;
using BeerTracking_be.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using MongoCrud.Data;
using MongoCrud.Domain;

namespace BeerTracking_be
{
    public abstract class BaseController<TType> : Controller
        where TType : IBaseEntity
    {
        private readonly BaseManager<TType> manager;

        public BaseController(BaseManager<TType> manager)
        {
            this.manager = manager;
        }

        [HttpPost]
        public TType Create([FromBody] TType newBrewery)
        {
            manager.Create(newBrewery);

            return newBrewery;
        }

        [HttpDelete("{id:Guid}")]
        public void Delete(Guid id)
        {
            manager.Delete(id);
        }

        [HttpPut("{id:Guid}")]
        public TType Update(Guid id, [FromBody] TType updates)
        {
            //Update Name
            //Update ThumbnailUrl
            //Save Brewery
            //Return Updated Brewery

            throw new NotImplementedException(); // Get rid of this line, I just hate squggly lines
        }

        [HttpGet("{id:Guid}")]
        public TType FindById(Guid id)
        {
            return manager.Get(id);
        }
    }
}