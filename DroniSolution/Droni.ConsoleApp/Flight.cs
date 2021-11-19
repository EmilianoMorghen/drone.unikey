using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droni.ConsoleApp
{
    internal class Flight
    {
        public string Id { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public Aircraft aircraft { get; }

        
    }
}
