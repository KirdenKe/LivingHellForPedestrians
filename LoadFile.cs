using AngleSharp;
using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Windows.Forms;

namespace LivingHellForPedestrians
{
    public class LoadFile
    {
        public List<Object> LivingHell = new List<Object>();
        public async Task LoadAccident()
        {
            var config = Configuration.Default.WithDefaultLoader();
            var browser = BrowsingContext.New(config);
            //這裡填入表格的網址
            var url = new Url("https://stat.motc.gov.tw/mocdb/stmain.jsp?sys=220&ym=9701&ymt=11202&kind=21&type=1&funid=b330702&cycle=41&outmode=0&compmode=0&outkind=1&fldlst=111&codspc0=0,25,&rdm=hai9yc5i");
            //要等一下才會跑出來
            var document = await browser.OpenAsync(url);
            //表格有幾列
            var MaxIndex = document.QuerySelector("body > form > table:nth-child(2) > tbody").ChildElementCount;
            for(int i = 3; i < MaxIndex; i += 13) 
            {
                //開瀏覽器，選取文字，右鍵，檢查，在Elememt視窗點右鍵，Copy，Copy selector，貼到程式碼裡
                var YearTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > th", i);//事故年分
                //基隆
                var KLUAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(20)", i);
                var KLUDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(20)", i);
                var KLUInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(20)", i);
                //新北
                var TPHAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);
                var TPHDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);
                var TPHInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);
                int year = int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", ""));
                //台北
                var TPEAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(4)", i);
                var TPEDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(4)", i);
                var TPEInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(4)", i);
                //桃園
                var TYCAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(4)", i);
                var TYCDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(5)", i);
                var TYCInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(5)", i);
                //新竹縣
                var HSHAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(10)", i);
                var HSHDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(10)", i);
                var HSHInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(10)", i);
                //新竹市
                var HSCAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(21)", i);
                var HSCDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(21)", i);
                var HSCInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(21)", i);
                //苗栗縣
                var MALAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(11)", i);
                var MALDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(11)", i);
                var MALInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(11)", i);
                //台中市
                var TXGAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(6)", i);
                var TXGDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(6)", i);
                var TXGInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) >> td:nth-child(6)", i);
                //彰化縣
                var CWHAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(12)", i);
                var CWHDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(12)", i);
                var CWHInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(12)", i);
                //南投縣
                var NTOAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(13)", i);
                var NTODeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(13)", i);
                var NTOInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(13)", i);
                //雲林縣
                var YLHAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(14)", i);
                var YLHDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(14)", i);
                var YLHInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(14)", i);
                //嘉義縣
                var CHYAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(15)", i);
                var CHYDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(15)", i);
                var CHYInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(15)", i);
                //嘉義市
                var CYIAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(22)", i);
                var CYIDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(22)", i);
                var CYIInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(22)", i);
                //台南市
                var TNNAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(7)", i);
                var TNNDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(7)", i);
                var TNNInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(7)", i);
                //高雄市
                var KHHAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var KHHDeathTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var KHHInjuredTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                //屏東縣
                var IUHAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(16)", i);
                var IUHDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(16)", i);
                var IUHInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(16)", i);
                //宜蘭縣
                var ILNAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(9)", i);
                var ILNDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(9)", i);
                var ILNInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(9)", i);
                //花蓮縣
                var HWAAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(18)", i);
                var HWADeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(18)", i);
                var HWAInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(18)", i);
                //台東縣
                var TTTAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(17)", i);
                var TTTDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(17)", i);
                var TTTInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(17)", i);
                //澎湖縣
                var PEHAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(19)", i);
                var PEHDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(19)", i);
                var PEHInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(19)", i);
                //金門縣
                var KMNAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(23)", i);
                var KMNDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(23)", i);
                var KMNInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(23)", i);
                //連江縣
                var LNNAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(24)", i);
                var LNNDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(24)", i);
                var LNNInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(24)", i);
                //把資料丟入List裡
                LivingHell.Add(new Place(County.KLU, year, int.Parse(document.QuerySelector(KLUAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(KLUDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(KLUInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.TPH, year, int.Parse(document.QuerySelector(TPHAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(TPHDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(TPHInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.TYC, year, int.Parse(document.QuerySelector(TYCAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(TYCDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(TYCInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.HSC, year, int.Parse(document.QuerySelector(HSCAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(HSCDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(HSCInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.HSH, year, int.Parse(document.QuerySelector(HSHAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(HSHDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(HSHInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.MAL, year, int.Parse(document.QuerySelector(MALAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(MALDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(MALInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.TXG, year, int.Parse(document.QuerySelector(TXGAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(TXGDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(TXGInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.CWH, year, int.Parse(document.QuerySelector(CWHAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(CWHDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(CWHInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.NTO, year, int.Parse(document.QuerySelector(NTOAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(NTODeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(NTOInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.YLH, year, int.Parse(document.QuerySelector(YLHAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(YLHDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(YLHInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.CHY, year, int.Parse(document.QuerySelector(CHYAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(CHYDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(CHYInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.CYI, year, int.Parse(document.QuerySelector(CYIAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(CYIDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(CYIInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.TNN, year, int.Parse(document.QuerySelector(TNNAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(TNNDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(TNNInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.KHH, year, int.Parse(document.QuerySelector(KHHAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(KHHDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(KHHInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.IUH, year, int.Parse(document.QuerySelector(IUHAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(IUHDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(IUHInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.ILN, year, int.Parse(document.QuerySelector(ILNAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(ILNDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(ILNInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.HWA, year, int.Parse(document.QuerySelector(HWAAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(HWADeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(HWAInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.TTT, year, int.Parse(document.QuerySelector(TTTAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(TTTDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(TTTInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.PEH, year, int.Parse(document.QuerySelector(PEHAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(PEHDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(PEHInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.KMN, year, int.Parse(document.QuerySelector(KMNAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(KMNDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(KMNInjuredTextSelector).InnerHtml.Replace(",", ""))));
                LivingHell.Add(new Place(County.LNN, year, int.Parse(document.QuerySelector(LNNAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(LNNDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(LNNInjuredTextSelector).InnerHtml.Replace(",", ""))));
            }
            url = new Url("https://stat.motc.gov.tw/mocdb/stmain.jsp?sys=220&ym=10301&ymt=11202&kind=21&type=1&funid=b330701&cycle=41&outmode=0&compmode=0&outkind=1&fldlst=111&codspc0=0,25,&rdm=qe6lUU7t");
            document = await browser.OpenAsync(url);
            MaxIndex = document.QuerySelector("body > form > table:nth-child(2) > tbody").ChildElementCount;
            for (int i = 3; i < MaxIndex; i += 13)
            {
                var YearTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > th", i);//事故年分
                var DrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);//新北市事故件數
                var DrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);//新北市死亡人數
                var DrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);//新北市受傷人數
                int year = int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", ""));
                //基隆市
                var KLUDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);
                var KLUDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);
                var KLUDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);
                //臺北市
                var TPEDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(4)", i);
                var TPEDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(4)", i);
                var TPEDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(4)", i);
                //桃園市
                var TYCDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(5)", i);
                var TYCDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(5)", i);
                var TYCDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(5)", i);
                //新竹縣
                var HSHDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(10)", i);
                var HSHDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(10)", i);
                var HSHDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(10)", i);
                //新竹市
                var HSCDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) >  td:nth-child(21)", i);
                var HSCDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) >  td:nth-child(21)", i);
                var HSCDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(21)", i);
                //苗栗縣
                var MALDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(11)", i);
                var MALDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(11)", i);
                var MALDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(11)", i);
                //台中市
                var TXGDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(6)", i);
                var TXGDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(6)", i);
                var TXGDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(6)", i);
                //彰化縣
                var CWHDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(12)", i);
                var CWHDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(12)", i);
                var CWHDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(12)", i);
                //南投縣
                var NTODrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(13)", i);
                var NTODrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(13)", i);
                var NTODrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(13)", i);
                //雲林縣
                var YLHDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(14)", i);
                var YLHDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(14)", i);
                var YLHDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(14)", i);
                //嘉義縣
                var CHYDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(15)", i);
                var CHYDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(15)", i);
                var CHYDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(15)", i);
                //嘉義市
                var CYIDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(22)", i);
                var CYIDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(22)", i);
                var CYIDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(22)", i);
                //台南市
                var TNNDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(7)", i);
                var TNNDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(7)", i);
                var TNNDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(7)", i);
                //高雄市
                var KHHDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var KHHDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var KHHDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                //屏東縣
                var IUHDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(16)", i);
                var IUHDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(16)", i);
                var IUHDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(16)", i);
                //宜蘭縣
                var ILNDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(9)", i);
                var ILNDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(9)", i);
                var ILNDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(9)", i);
                //花蓮縣
                var HWADrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(18)", i);
                var HWADrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(18)", i);
                var HWADrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(18)", i);
                //台東縣
                var TTTDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(17)", i);
                var TTTDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(17)", i);
                var TTTDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(17)", i);
                //澎湖縣
                var PEHDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(19)", i);
                var PEHDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(19)", i);
                var PEHDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(19)", i);
                //金門縣
                var KMNDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(23)", i);
                var KMNDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(23)", i);
                var KMNDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(23)", i);
                //連江縣
                var LNNDrunkAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(24)", i);
                var LNNDrunkDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(24)", i);
                var LNNDrunkInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(24)", i);
                for (int j = 0; j < LivingHell.Count; j++)
                {
                    var livingHell = (Place)LivingHell[j];
                    if (livingHell.Year == year && livingHell.county == County.TPH)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(DrunkAccidentTextSelector).InnerHtml.Replace(",", ""));//新北市酒駕事故事件
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(DrunkDeathTextSelector).InnerHtml.Replace(",", ""));//新北市酒駕死亡人數
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(DrunkInjuredTextSelector).InnerHtml.Replace(",", ""));//新北市酒駕受傷人數
                        LivingHell[j] = livingHell;
                    }
                    //基隆市
                    if (livingHell.Year == year && livingHell.county == County.KLU)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(KLUDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(KLUDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(KLUDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    //台北市
                    if (livingHell.Year == year && livingHell.county == County.TPE)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(TPEDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(TPEDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(TPEDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    //桃園市
                    if (livingHell.Year == year && livingHell.county == County.TYC)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(TYCDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(TYCDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(TYCDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    //新竹縣
                    if (livingHell.Year == year && livingHell.county == County.HSH)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(HSHDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(HSHDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(HSHDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    //新竹市
                    if (livingHell.Year == year && livingHell.county == County.HSC)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(HSCDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(HSCDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(HSCDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    //苗栗縣
                    if (livingHell.Year == year && livingHell.county == County.MAL)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(MALDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(MALDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(MALDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    //台中市
                    if (livingHell.Year == year && livingHell.county == County.TXG)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(TXGDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(TXGDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(TXGDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    //彰化縣
                    if (livingHell.Year == year && livingHell.county == County.CWH)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(CWHDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(CWHDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(CWHDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    if (livingHell.Year == year && livingHell.county == County.NTO)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(NTODrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(NTODrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(NTODrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    if (livingHell.Year == year && livingHell.county == County.CHY)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(CHYDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(CHYDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(CHYDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    if (livingHell.Year == year && livingHell.county == County.CYI)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(CYIDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(CYIDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(CYIDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    if (livingHell.Year == year && livingHell.county == County.TNN)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(TNNDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(TNNDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(TNNDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    if (livingHell.Year == year && livingHell.county == County.KHH)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(KHHDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(KHHDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(KHHDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    if (livingHell.Year == year && livingHell.county == County.IUH)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(IUHDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(IUHDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(IUHDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    if (livingHell.Year == year && livingHell.county == County.ILN)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(ILNDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(ILNDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(ILNDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    if (livingHell.Year == year && livingHell.county == County.HWA)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(HWADrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(HWADrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(HWADrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    if (livingHell.Year == year && livingHell.county == County.TTT)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(TTTDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(TTTDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(TTTDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    if (livingHell.Year == year && livingHell.county == County.PEH)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(PEHDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(PEHDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(PEHDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    if (livingHell.Year == year && livingHell.county == County.KMN)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(KMNDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(KMNDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(KMNDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                    if (livingHell.Year == year && livingHell.county == County.LNN)
                    {
                        livingHell.DrunkAccidentNum = int.Parse(document.QuerySelector(LNNDrunkAccidentTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.DrunkDeathNum = int.Parse(document.QuerySelector(LNNDrunkDeathTextSelector).InnerHtml.Replace(",", ""));
                        livingHell.InjuredNumber = int.Parse(document.QuerySelector(LNNDrunkInjuredTextSelector).InnerHtml.Replace(",", ""));
                        LivingHell[j] = livingHell;
                    }
                }
            }
            url = new Url("https://stat.motc.gov.tw/mocdb/stmain.jsp?sys=220&ym=9701&ymt=11202&kind=21&type=1&funid=b330704&cycle=41&outmode=0&compmode=0&outkind=1&fldlst=111&codlst0=1100100100100110011111&rdm=BWr7bfgq");
            document = await browser.OpenAsync(url);
            MaxIndex = document.QuerySelector("body > form > table:nth-child(2) > tbody").ChildElementCount;
            for (int i = 3; i < MaxIndex; i += 13)
            {
                var YearTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > th", i);//事故年分
                var AccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);//大客車事故件數
                var DeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);//大客車死亡人數
                var InjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);//大客車受傷人數
                LivingHell.Add(new Tool(ToolType.Bus, int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", "")), int.Parse(document.QuerySelector(AccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(DeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(InjuredTextSelector).InnerHtml.Replace(",", ""))));
                //大貨車
                var BigTruckAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(4)", i);
                var BigTruckDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(4)", i);
                var BigTruckInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(4)", i);
                LivingHell.Add(new Tool(ToolType.BigTruck, int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", "")), int.Parse(document.QuerySelector(BigTruckAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(BigTruckDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(BigTruckInjuredTextSelector).InnerHtml.Replace(",", ""))));
                //minibus
                var minibusdAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(5)", i);
                var minibusDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(5)", i);
                var minibusInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(5)", i);
                LivingHell.Add(new Tool(ToolType.Minibus, int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", "")), int.Parse(document.QuerySelector(minibusdAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(minibusDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(minibusInjuredTextSelector).InnerHtml.Replace(",", ""))));
                //smalltruck
                var SmallTruckAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(6)", i);
                var SmallTruckDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(6)", i);
                var SmallTruckInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(6)", i);
                LivingHell.Add(new Tool(ToolType.SmallTruck, int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", "")), int.Parse(document.QuerySelector(SmallTruckAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(SmallTruckDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(SmallTruckInjuredTextSelector).InnerHtml.Replace(",", ""))));
                //specialvehicle
                var SpecialVehicleAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(7)", i);
                var SpecialVehicleDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(7)", i);
                var SpecialVehicleInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(7)", i);
                LivingHell.Add(new Tool(ToolType.SpecialVehicle, int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", "")), int.Parse(document.QuerySelector(SpecialVehicleAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(SpecialVehicleDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(SpecialVehicleInjuredTextSelector).InnerHtml.Replace(",", ""))));
                //locomotive
                var LocomotiveAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var LocomotiveDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var LocomotiveInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                LivingHell.Add(new Tool(ToolType.Locomotive, int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", "")), int.Parse(document.QuerySelector(LocomotiveAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(LocomotiveDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(LocomotiveInjuredTextSelector).InnerHtml.Replace(",", ""))));
                //bike 
                var BikeAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var BikeDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var BikeInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                LivingHell.Add(new Tool(ToolType.Bike, int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", "")), int.Parse(document.QuerySelector(BikeAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(BikeDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(BikeInjuredTextSelector).InnerHtml.Replace(",", ""))));
                //pedestrian
                var PedestrianAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var PedestrianDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var PedestrianInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                LivingHell.Add(new Tool(ToolType.Pedestrian, int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", "")), int.Parse(document.QuerySelector(PedestrianAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(PedestrianDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(PedestrianInjuredTextSelector).InnerHtml.Replace(",", ""))));
                //passenger
                var PassengerAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var PassengerDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var PassengerInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                LivingHell.Add(new Tool(ToolType.Passenger, int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", "")), int.Parse(document.QuerySelector(PassengerAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(PassengerDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(PassengerInjuredTextSelector).InnerHtml.Replace(",", ""))));
                //other
                var OtherAccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var OtherDeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                var OtherInjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(8)", i);
                LivingHell.Add(new Tool(ToolType.Other, int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", "")), int.Parse(document.QuerySelector(OtherAccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(OtherDeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(OtherInjuredTextSelector).InnerHtml.Replace(",", ""))));
                //unknown
            }

            //釋放權柄
            document.Close();
        }
    }
}
