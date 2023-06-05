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
    }
    public class AgeDead
    {
        public int Year { get; set;  }
        public int under12years { get; set; }
        public int between12to17 { get; set; }
        public int between18to24 { get; set; }
        public int between25to64 { get; set; }
        public int upper65 { get; set; }
        public AgeDead(int year, int under12years, int between12to17, int between18to24, int between25to64, int upper65)
        {
            Year = year;
            this.under12years = under12years;
            this.between12to17 = between12to17;
            this.between18to24 = between18to24;
            this.between25to64 = between25to64;
            this.upper65 = upper65;
        }
        public int Number(int index)
        {
            switch (index)
            {
                case 0: return under12years;
                case 1: return between12to17;
                case 2: return between18to24;
                case 3: return between25to64;
                case 4: return upper65;
            }
            return -1;
        }
    }
    interface ChooseNumber
    {
        int Number(int index);
    }
}
