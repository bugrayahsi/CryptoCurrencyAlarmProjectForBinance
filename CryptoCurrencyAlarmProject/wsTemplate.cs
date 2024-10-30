using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyAlarmProject
{
    public class wsTemplate
    {
        public string e = string.Empty; //EventType
        public double E = 0;            //EventTime   
        public string s = string.Empty; //Symbol
        public double t = 0;            //TradeID
        public string p = string.Empty; //Price
        public string q = string.Empty; //Quantity
        public double b = 0;            //BuyerOrderID
        public double a = 0;            //SellerOrderID
        public double T = 0;            //TradeTime
        public bool m = true;           //Is the Buyer the market maker?
        public bool M = true;           //Ignore
    }
}
