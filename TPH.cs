using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingHellForPedestrians
{
    public class TPH : ACCIDENT
    {
        public int Year { get; set; }
        public int DrunkAccidentNum
        {
            get { return DRUNK.AccidentNumber; }
            set { DRUNK.AccidentNumber = value;}
        }
        public int DrunkDeathNum
        {
            get { return DRUNK.DeathToll; }
            set { DRUNK.DeathToll = value; }
        }
        public int DrunkInjuredNum
        {
            get { return DRUNK.InjuredNumber; }
            set { DRUNK.InjuredNumber = value; }
        }
        public TPH(int year, int accident, int death, int injured)
        {
            this.AccidentNumber = accident;
            this.Year = year;
            this.DeathToll = death;
            this.InjuredNumber = injured;
        }
    }
}
