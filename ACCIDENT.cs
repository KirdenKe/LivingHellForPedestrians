using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingHellForPedestrians
{
    public class ACCIDENT
    {
        public int AccidentNumber { get; set; }
        public int DeathToll { get; set; }
        public int InjuredNumber { get; set; }
        public class DRUNK
        {
            public static int AccidentNumber { get; set; }
            public static int DeathToll { get; set; }
            public static int InjuredNumber { get; set; }
        }
    }
    public class AgeDead
    {
        public int Year { get; set;  }
        public int under12years { get; set; }
        public int between12to17 { get; set; }
        public int between18to24 { get; set; }
        public int between25to64 { get; set; }
        public int upper65 { get; set; }
    }
}
