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
            /*定義縣市



            */
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
                var AccidentTextSelector = String.Format("body > form > table:nth-child(2) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);//新北市事故件數
                var DeathTextSelector = String.Format("body > form > table:nth-child(3) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);//新北市死亡人數
                var InjuredTextSelector = String.Format("body > form > table:nth-child(4) > tbody > tr:nth-child({0}) > td:nth-child(3)", i);//新北市受傷人數
                int year = int.Parse(document.QuerySelector(YearTextSelector).InnerHtml.Substring(0, 3).Replace("年", ""));
                //把資料丟入List裡
                LivingHell.Add(new Place(County.TPH, year, int.Parse(document.QuerySelector(AccidentTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(DeathTextSelector).InnerHtml.Replace(",", "")), int.Parse(document.QuerySelector(InjuredTextSelector).InnerHtml.Replace(",", ""))));
                /*其他縣市
                


                */
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
                    /*其他縣市



                    */
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
            }
            //釋放權柄
            document.Close();
        }
    }
}
