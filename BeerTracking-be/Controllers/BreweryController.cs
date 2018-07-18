using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerTracking_be.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoCrud.Data;
using MongoCrud.Data.Breweries;
using MongoCrud.Domain.Breweries;

namespace BeerTracking_be.Controllers
{ 
    [Produces("application/json")]
    [Route("api/breweries")]
    public class BreweryController : BaseController<Brewery>
    {
        public BreweryController(BaseManager<Brewery> manager) : base(manager)
        {
        }
    }
}