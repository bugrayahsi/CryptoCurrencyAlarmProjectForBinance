using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WebSocketSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CryptoCurrencyAlarmProject
{
    public partial class Form1 : Form
    {
        Functions functions = new Functions();
        JsonWork jsonwork = new JsonWork();      
        List<AlarmTemplate> a1 = new List<AlarmTemplate>();
        wsTemplate wsTemplate = new wsTemplate();
        string[] pairs = {"btc", "eth","bnb","sol","xrp","doge","ada","avax","bch","dot","trx","link","matic","near","ltc","uni","etc",
            "fil","atom","xlm","hbar","vet","mkr","grt","theta","ftm","rune","xmr","algo","aave","neo","egld","axs","sand","chz","snx","xtz",
            "eos","mana","kava"};
        string alarms = string.Empty;
        string showActiveAlarms = string.Empty;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            a1 = jsonwork.readJsonData();
            Array.Sort(pairs);
            comboBoxPairs.Items.AddRange(pairs);
            KlineTemplate klineTemplate = new KlineTemplate();           
            jsonwork.CreateJson();
            int selectedindex = comboBoxPairs.SelectedIndex;
        }

        private void addAlarmButton_Click(object sender, EventArgs e)
        {
            AlarmTemplate alarmTemplate = new AlarmTemplate();
            functions.comboboxAlarmAddCheck(comboBoxPairs.SelectedIndex);
            bool t1 = string.IsNullOrEmpty(textBox1.Text);
            bool t2 = string.IsNullOrEmpty(textBox2.Text);
            bool t3 = t1 && t2;
            functions.AlarmsTextBoxControl(t3);
            alarmTemplate.PairName = pairs.ElementAt(comboBoxPairs.SelectedIndex);
            int holdIndex;
            if (/*a1.Count==0 ||*/ a1 ==null)
            {
                alarmTemplate.AlarmId = 1;
                holdIndex = 0;
                a1 = new List<AlarmTemplate>();
            }
            else 
            {
                alarmTemplate.AlarmId = a1.Count+1;
                holdIndex = a1.Count-1;
            }
            if (textBox1.Text == "") { textBox1.Text = "0"; }
            if (textBox2.Text == "") { textBox2.Text = "0"; }
            alarmTemplate.UpperAlarm = textBox1.Text;
            alarmTemplate.LowerAlarm = textBox2.Text;                     
            a1.Add(alarmTemplate);           
            jsonwork.writeJsonData(functions.IdFixer(a1));
            showActiveAlarmsRichTextBox.Text = functions.ShowActiveAlarms(functions.IdFixer(a1));   
        }

        private void strtConnectionButton_Click(object sender, EventArgs e)
        {
            WebSocket ws = new WebSocket(functions.WebSocketUrl(a1));
            ws.ConnectAsync();
            ws.OnMessage += Ws_OnMessage;
        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            wsTemplate = JsonConvert.DeserializeObject<wsTemplate>(e.Data);
            string symbol = wsTemplate.s;
            string price = wsTemplate.p;
            int c = functions.FindPair(a1, symbol,price)-1;
            if (c >= 0)
            {
                a1 = functions.IdFixer(a1);
                MessageBox.Show(a1[c].PairName + "Has Activated", "ALARM" + a1[c].PairName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                a1.RemoveAt(c);
                showActiveAlarmsRichTextBox.Text = functions.ShowActiveAlarms(functions.IdFixer(a1));
                jsonwork.writeJsonData(functions.IdFixer(a1));
            }
        }

        private void RemoveAlarmButton_Click(object sender, EventArgs e)
        {
           string rmv = RemoveAlarmTextBox.Text;
           a1 = functions.RemoveAlarm(a1, int.Parse(rmv, CultureInfo.InvariantCulture));
           a1 = functions.IdFixer(a1);
           label1.Text = rmv;
        }
    }
}
