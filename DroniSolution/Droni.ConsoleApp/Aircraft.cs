using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droni.ConsoleApp
{
    
    internal class Aircraft
    { 
        [Flags]
        public enum _mechanics 
        {
               manned ,
               unmanned,
        }
        public enum _pilot
        {
            rotor,  
            wing,
            meccanicalissue,
        }
        public int Id { get; }

        public DateTime OurFly { get; }

        public _mechanics Mechanics { get; }

        public _pilot Pilot {get; }
    }
}
