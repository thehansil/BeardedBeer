using System;
using System.Collections.Generic;
using BeerTracking_be.Application;
using BeerTracking_be.Data.Beers;
using Microsoft.AspNetCore.Mvc;
using MongoCrud.Data;
using MongoCrud.Domain.Beers;

namespace BeerTracking_be.Controllers
{
    [Produces("application/json")]
    [Route("api/Beer")]
    public class BeerController : BaseController<Beer>
    {
        public BeerController(BaseManager<Beer> manager) : base(manager)
        {
        }

        [Route("abv/{from:decimal}-{to:decimal}")]
        public List<Beer> FindBeerByAbv([FromRoute] decimal from, [FromRoute] decimal to)
        {
            throw new Exception("foo");
        }
    }
}