using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droni.ConsoleApp
{
    internal class DroneFleet
    {
        private List<Mission> _missions = new List<Mission>();

        public DroneFleet(List<Mission> missions)
        {
            _missions = missions;
        }

        public Mission? DetailsOfMission(int id) => _missions.Find(mission => mission.Id == id);


    }
}
