using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnhappyPizza
{
    public partial class MainForm : Form
    {
        private const int lenght = 6;
        private string url;
        private static char[] chars =
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            'a', 'b'
        };

        public MainForm()
        {
            InitializeComponent();
            url = tbUrl.Text;
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
        }

        private StringBuilder ChangeCharacters(int pos, StringBuilder sb, int length)
        {
            for (int i = 0; i <= chars.Length - 1; i++)
            {
                sb.Replace(sb[pos], chars[i], pos, 1);
                if (pos == length - 1)
                {
                    tbMain.Invoke(new Action(() => tbMain.Text += url + sb.ToString() + Environment.NewLine));
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
        }
    }
}
