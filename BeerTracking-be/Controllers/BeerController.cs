using System;
using System.Collections.Generic;
using BeerTracking_be.Application;
using BeerTracking_be.Data.Beers;
using Microsoft.AspNetCore.Mvc;
using MongoCrud.Data;
using MongoCrud.Domain.Beers;
using MongoCrud.Domain.Breweries;

namespace BeerTracking_be.Controllers
{
    [Produces("application/json")]
    [Route("api/Beer")]
    public class BeerController : BaseController<Beer>
    {
        private readonly BeerManager beerManager;
        public BeerController(BaseManager<Beer> manager) : base(manager)
        {
            this.beerManager = manager as BeerManager;
        }

        [Route("abv/{from:decimal}-{to:decimal}")]
        public List<Beer> FindBeerByAbv([FromRoute] decimal from, [FromRoute] decimal to)
        {
            throw new Exception("foo");
        }

        [Route("api/beer/{name}")]
        [HttpGet]
        public Beer FindBeerByName(string name)
        {
            return beerManager.FindBeerByName(name);
        }

        [HttpGet]
        [Route("/tags")]
        public IActionResult GetBeersContainingTag([FromBody] IEnumerable<string> tags)
        {
            return Ok(beerManager.GetBeersWithTags(tags));
        }

        [HttpGet]
        [Route("/breweries")]
        public IActionResult GetAllBeersAtBrewery([FromBody] Brewery brewery)
        {
            return Ok(beerManager.GetAllBeersAtBrewery(brewery));
        }

        [HttpGet]
        [Route("/{id}")]
        public IActionResult FindBeerByBrewery([FromRoute] Guid id)
        {
            return Ok(beerManager.GetAllBeersByBrewery(id));
        }
    }
}