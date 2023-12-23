using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Parking
    {
        public required decimal InitialPrice { get; set; }
        public required decimal HourPrice { get; set; }
    }
}