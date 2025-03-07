using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyAlarmProject
{
    public class JsonWork
    {
        List<AlarmTemplate> alarms;
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Alarms.json";
        public void CreateJson()
        {
            if(!File.Exists(path)) { File.WriteAllText(path, "");}         
        }
        public List<AlarmTemplate> readJsonData()
        {
            CreateJson();
            string readAlarms = File.ReadAllText(path);
            List<AlarmTemplate> a1 = JsonConvert.DeserializeObject<List<AlarmTemplate>>(readAlarms);         
            return a1;
        }
        public void writeJsonData(List<AlarmTemplate> alarmTemplate)
        {
            string Jstring = JsonConvert.SerializeObject(alarmTemplate);
            File.WriteAllText(path, Jstring);
        }
    }
}
