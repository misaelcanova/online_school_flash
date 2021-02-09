using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_videolezioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string out1, out2, out3, out4, out5;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            out1 = "chrome";
            out2 = "https://meet.google.com/landing?authuser=1";
            out3 = "3finf";
            out4 = "";
            out5 = "";

        
            if (checkBox1.Checked)
                out4 = "-1";
            else if (checkBox2.Checked)
                out4 = "-2";
            else if (checkBox3.Checked)
                out4 = "-3";
            else if (checkBox4.Checked)
                out4 = "-4";
            else if (checkBox5.Checked)
                out4 = "-5";
            else if (checkBox6.Checked)
                out4 = "-6";
            else
                MessageBox.Show("seleziona una lezione in cui entrare");
            out5 = out3 + out4;

            
            SendKeys.Send("^({ESC}E)");
            SendKeys.Send(out1);
            SendKeys.Send("{Enter}");
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send(out2);
            SendKeys.Send("{Enter}");
            System.Threading.Thread.Sleep(1500);
            SendKeys.Send(out5);
            SendKeys.Send("{Enter}");

            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{Enter}");

            System.Threading.Thread.Sleep(1500);
            SendKeys.Send("^d");
            SendKeys.Send("^e");

            System.Threading.Thread.Sleep(4000);
            LeftMouseClick(1250, 600);

        }
    }
}
