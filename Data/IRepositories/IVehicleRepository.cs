﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_API_Vehicles.Models;

namespace Teste_API_Vehicles.Data.Repositories
{
    public interface IVehicleRepository
    {
        void Create(Vehicle vehicle);

        void Update(Vehicle vehicle);

        void Delete(int id);

        IEnumerable<Vehicle> ListVehicle();

        Vehicle SearchVehicle(int id);

    }
}
