using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCurrencyAlarmProject
{
    public class Functions
    {
        public DateTime timeConverter(double UnixData)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddMilliseconds(UnixData).ToLocalTime();
            return dateTime;
        }

        public void comboboxAlarmAddCheck(int selectedindex)
        {
            if (selectedindex == -1) { MessageBox.Show("Please pick a pair", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        public void AlarmsTextBoxControl(bool NullorEmpty)
        {
            if (NullorEmpty) { MessageBox.Show("Please enter a Alarm Price", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        public string WebSocketUrl(List<AlarmTemplate> alarm)
        {
            string baseUrl = "wss://stream.binance.com:9443/ws/";
            foreach (AlarmTemplate alarmTemplate in alarm)
            {
                baseUrl += alarmTemplate.PairName + "usdt@trade" + "/" ;
            }
            baseUrl = baseUrl.Remove(baseUrl.Length-1,1);
            return baseUrl;
        }
        
        public int FindPair(List<AlarmTemplate> a1 , string pair , string currentPrice)
        {
            foreach (AlarmTemplate a2 in a1)
            {
                if (a2.PairName.ToUpper()+"USDT" == pair)
                {
                    if (double.Parse(a2.UpperAlarm, CultureInfo.InvariantCulture) <= double.Parse(currentPrice, CultureInfo.InvariantCulture)&& a2.UpperAlarm!="" && a2.UpperAlarm!=null)
                    {
                        return a2.AlarmId;
                    }
                    else if (double.Parse(a2.LowerAlarm, CultureInfo.InvariantCulture) >= double.Parse(currentPrice, CultureInfo.InvariantCulture)&& a2.LowerAlarm!="" &&a2.LowerAlarm!= null)
                    {
                        return a2.AlarmId;
                    }              
                }
            }
            return -1;            
        }
        
        public string ShowActiveAlarms(List<AlarmTemplate> a1)
        {
            string ShowActiveAlarms = string.Empty;
            for (int i = 0; i < a1.Count; i++)
            {
                ShowActiveAlarms += a1[i].AlarmId.ToString() + " - " + a1[i].PairName + " - " + a1[i].UpperAlarm + " - " + a1[i].LowerAlarm + Environment.NewLine;
            }
            return ShowActiveAlarms;
        }

        public List<AlarmTemplate> IdFixer(List<AlarmTemplate> a1)
        {
            int x = 1;
            for (int i = 0; i < a1.Count; i++)
            {
                a1[i].AlarmId = x;
                x++;
            }
            return a1;
        }

        public List<AlarmTemplate> RemoveAlarm(List<AlarmTemplate> a1 , int id)
        {
            a1.RemoveAt(id - 1);
            return a1;
        }
    }
}
