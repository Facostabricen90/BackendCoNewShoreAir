using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;
using BusinessLayer.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer
{
    public class FlightsController : ControllerBase
    {
        private readonly FlightUseCase flightUseCase;

        public FlightsController(FlightUseCase flightUseCase)
        {
            this.flightUseCase = flightUseCase;
        }

        // GET: api/<FlightsController>
        [HttpGet("{origin}/{destination}")]
        public async Task<Journey> Get(string origin, string destination) => await flightUseCase.GetJourney(origin, destination);
    }
}
