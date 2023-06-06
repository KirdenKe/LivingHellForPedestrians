using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LivingHellForPedestrians
{
    public enum County
    {
        KLU,//基隆市
        TPH,//新北市
        TPE,//臺北市
        TYC,//桃園市
        HSH,//新竹縣
        HSC,//新竹市
        MAL,//苗栗縣
        TXG,//臺中市
        CWH,//彰化縣
        NTO,//南投縣
        YLH,//雲林縣
        CHY,//嘉義縣
        CYI,//嘉義市
        TNN,//臺南市
        KHH,//高雄市
        IUH,//屏東縣
        ILN,//宜蘭縣
        HWA,//花蓮縣
        TTT,//臺東縣
        PEH,//澎湖縣
        KMN,//金門縣
        LNN//連江縣
    }
    public class Place : ACCIDENT, ChooseNumber
    {
        internal class DRUNK
        {
            internal int AccidentNumber { get; set; }
            internal int DeathToll { get; set; }
            internal int InjuredNumber { get; set; }
        }
        DRUNK drunk = new DRUNK();
        public County county { get; set; }
        public int Year { get; set; }
        public int DrunkAccidentNum
        {
            get { return drunk.AccidentNumber; }
            set { drunk.AccidentNumber = value; }
        }
        public int DrunkDeathNum
        {
            get { return drunk.DeathToll; }
            set { drunk.DeathToll = value; }
        }
        public int DrunkInjuredNum
        {
            get { return drunk.InjuredNumber; }
            set { drunk.InjuredNumber = value; }
        }
        public int listBoxIndex = -1;
        public int newNumber = 0;
        public Place(County county, int year, int accident, int death, int injured)
        {
            this.county = county;
            this.AccidentNumber = accident;
            this.Year = year;
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
                case 3: return DrunkAccidentNum;
                case 4: return DrunkDeathNum;
                case 5: return DrunkInjuredNum;
            }
            return -1;
        }
        public static Place operator +(Place place, int NewNumber)
        {
            if (place.listBoxIndex == 0)
                place.AccidentNumber += NewNumber;
            else if(place.listBoxIndex == 1)
                place.DeathToll += NewNumber;
            else if (place.listBoxIndex == 2)
                place.InjuredNumber += NewNumber;
            else if (place.listBoxIndex == 3)
                place.drunk.AccidentNumber += NewNumber;
            else if (place.listBoxIndex == 4)
                place.drunk.DeathToll += NewNumber;
            else if (place.listBoxIndex == 5)
                place.drunk.InjuredNumber += NewNumber;
            return place;
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
            else if (i == 3)
                drunk.AccidentNumber = newNum;
            else if (i == 4)
                drunk.DeathToll = newNum;
            else if (i == 5)
                drunk.InjuredNumber = newNum;
        }
    }
}
