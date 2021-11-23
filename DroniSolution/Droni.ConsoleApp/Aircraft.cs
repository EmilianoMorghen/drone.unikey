using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droni.ConsoleApp
{
    internal class Aircraft
    {
        public int Id { get; }
        public DateTime Fligth { get; }

        public enum _mechanics
        {
            fixedwing,
            movablewing,
            rotor

        }
        public enum _pilot 
        {
            manned,
            unmanned
        }
        public _pilot Pilot { get; set; }
        public _mechanics Mechanics { get; set; }
        public Aircraft (int id, DateTime fligth, _mechanics mechanics, _pilot pilota)
        {
            Id = id;
            Fligth = fligth;
            Mechanics = mechanics;
            Pilot = pilota;
        }
    }
}
