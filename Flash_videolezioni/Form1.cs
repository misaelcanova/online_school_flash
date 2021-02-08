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

        }
    }
}
