using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyAlarmProject
{
    public class KlineTemplate
    {
        public KlineTemplate()
        {
            int id = 0;
            double Time = 0;
            double TimeHours = 0;
            double TimeMinutes = 0;
            double OpenPrice = 0;
            double ClosePrice = 0;
            double HighPrice = 0;
            double LowPrice = 0;
            bool KlineClosed = false;
        }
        List<KlineTemplate> klineTemplates = new List<KlineTemplate>();

        public List<KlineTemplate> returnKlineTemplate()
        {
            return this.klineTemplates;
        }
    }
}
