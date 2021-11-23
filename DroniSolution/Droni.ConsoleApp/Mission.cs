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
                foreach (Flight f in fligths)
                {
                    if (this.StartDate < f.StartDate && this.EndDate > f.EndDate)
                    {
                        var checkFlightDate = false;

                        foreach(Flight f1 in this._flights)
                        {
                            if(
                                (f1.StartDate > f.StartDate || f1.EndDate < f.StartDate)
                                &&
                                (f1.StartDate > f.EndDate || f1.EndDate < f.EndDate)
                            )
                            {
                                checkFlightDate = true;
                            }
                        }

                        if (checkFlightDate)
                        {
                            _flights.Add(f);
                            continue;
                        }

                    }
                    else
                        return false;
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

        public bool IsInMission(int id) => _aircrafts.Any(drone => drone.Id==id);
        

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
