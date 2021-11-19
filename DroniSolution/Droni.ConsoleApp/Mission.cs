using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droni.ConsoleApp
{
    internal class Mission
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Aircraft> Aircrafts { get; set; } = new List<Aircraft>();

        public List<Flight> Flights { get; set; } = new List<Flight>();
    }
}
