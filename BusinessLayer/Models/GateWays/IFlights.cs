﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Models.GateWays
{
    public interface IFlights
    {
        Task<List<Flight>> GetFlights(int id);
    }
}
