using System;
using System.Collections.Generic;
using System.Linq;
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
    public class Place : ACCIDENT
    {
        public County county { get; set; }
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
        public Place(County county, int year, int accident, int death, int injured)
        {
            this.county = county;
            this.AccidentNumber = accident;
            this.Year = year;
            this.DeathToll = death;
            this.InjuredNumber = injured;
        }
    }
}
