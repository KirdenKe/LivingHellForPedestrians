using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static LivingHellForPedestrians.Place;

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
    public class Tool : ACCIDENT, ChooseNumber
    {
        public ToolType Type { get; set;}
        public int Year { get; set; }
        public int listBoxIndex = -1;
        public int newNumber = 0;
        public Tool(ToolType type, int year, int accident, int death, int injured)
        {
            this.Type = type;
            this.Year = year;
            this.AccidentNumber = accident;
            this.DeathToll = death;
            this.InjuredNumber = injured;
        }
        public int Number(int index)
        {
            switch (index)
            {
                case 0: return AccidentNumber;
                case 1: return DeathToll;
                case 2: return InjuredNumber;
            }
            return -1;
        }
        public static Tool operator +(Tool tool, int NewNumber)
        {
            if (tool.listBoxIndex == 0)
                tool.AccidentNumber += NewNumber;
            else if (tool.listBoxIndex == 1)
                tool.DeathToll += NewNumber;
            else if (tool.listBoxIndex == 2)
                tool.InjuredNumber += NewNumber;
            return tool;
        }
        public override void updateData(out int index, out int NewNumber)
        {
            index = listBoxIndex;
            if (newNumber >= 0)
                NewNumber = newNumber;
            else
                NewNumber = 0;
        }
        public void UpdateData()
        {
            updateData(out int i, out int newNum);
            if (i == 0)
                AccidentNumber = newNum;
            else if (i == 1)
                DeathToll = newNum;
            else if (i == 2)
                InjuredNumber = newNum;
        }
    }
}
