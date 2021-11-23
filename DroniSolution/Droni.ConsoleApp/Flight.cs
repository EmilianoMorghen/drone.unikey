using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droni.ConsoleApp
{
    internal class Flight
    {
        public int Id { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public Aircraft Aircraft { get; }

        public Flight(int id,DateTime stratdate, DateTime endDate, Aircraft aircraft)
        {
            Id = id;
            StartDate = stratdate; 
            EndDate = endDate;
            Aircraft = aircraft;
        }


    }
}
