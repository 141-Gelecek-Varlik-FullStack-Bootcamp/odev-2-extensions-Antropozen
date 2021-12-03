using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    interface  IVehicle
    {
        int Id { get; set; }
        string Brand { get; set; }
        string Series { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        string Fuel { get; set; }
        string Gear { get; set; }
        int KM { get; set; }
        int EnginePower { get; set; }
        int EngineCapacity { get; set; }
        int Door { get; set; }
    }
}
