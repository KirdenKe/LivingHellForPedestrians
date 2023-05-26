using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingHellForPedestrians
{
    public enum ToolType
    {
        Bus,//大客車
        BigTruck,//大貨車
        Minibus,//小客車
        SmallTruck,//小貨車
        SpecialVehicle,//特種車
        Locomotive,//機車
        Bike,//自行車
        Pedestrian,//行人
        Passenger,//乘客
        Other,//其他
        Unknown//不明
    }
    public class Tool : ACCIDENT
    {
        public ToolType Type { get; set;}
        public int Year { get; set; }
        public Tool(ToolType type, int year, int accident, int death, int injured)
        {
            this.Type = type;
            this.Year = year;
            this.AccidentNumber = accident;
            this.DeathToll = death;
            this.InjuredNumber = injured;
        }
    }
}
