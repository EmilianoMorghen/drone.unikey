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

        private List<Aircraft> _aircrafts { get; set; } = new List<Aircraft>();

        private List<Flight> _flights { get; set; } = new List<Flight>();

        public Mission(int id, DateTime startDate, DateTime endTime, List<Aircraft> aircrafts, List<Flight> flights)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endTime;
            _aircrafts = aircrafts;
            _flights = flights;
        }

        public bool AddFlight(params Flight[] fligths)
        {
            if (fligths == null)
                return false;

            else
            {
                foreach (var f in fligths)
                {
                    _flights.Add(f);
                }
                return true;
            }
        }

        public bool AddAircraft(params Aircraft[] aircrafts)
        {
            if (aircrafts == null)
                return false;
            else
            {
                foreach (var aircraft in aircrafts)
                {
                    _aircrafts.Add(aircraft);
                }
                return true;
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            Mission other = obj as Mission;

            return this.Id == other.Id;
        }

        public override string ToString()
        {
            return $"Id mission: {Id}\n" +
                    $"Start date time: {StartDate.ToString()}\n" +
                    $"End date time: {EndDate.ToString()}\n" +
                    $"Aircrafts:\n {_aircrafts}\n" +
                    $"Fligths:\n {_flights}\n";
        }
    }
}
