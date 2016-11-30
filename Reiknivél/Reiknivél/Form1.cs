using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reiknivél
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string input = null;
        string firsthluta = null;
        string seinnihluta = null;
        string adferd = null;
        double Reikning = 0;
        double tala1 = 0, tala2 = 0;
        double memorie = 0;
        private void bt1_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Text += "1";
            input += "1";
            
        }
        private void bt2_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Text += "2";
            input += "2";
        }
        private void bt3_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Text += "3";
            input += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Text += "4";
            input += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Text += "5";
            input += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Text += "6";
            input += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Text += "7";
            input += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Text += "8";
            input += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Text += "9";
            input += "9";
        }
        private void bt0_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Text += "0";
            input += "0";
        }
        private void btC_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear();
            input = null;
            firsthluta = null;
            seinnihluta = null;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear();
            input = null;
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear();
            firsthluta = input;
            input = null;
            adferd = "+";
            
        }

        private void btReikna_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear();
            seinnihluta = input;
            input = null;
            double.TryParse(firsthluta, out tala1);
            double.TryParse(seinnihluta, out tala2);
            if (adferd == "+")
            {
                if (tala2 == 0)
                {
                    Reikning = Reikning + tala1;
                    rtbUtskrá.Text = Reikning.ToString();
                }
                else
                {
                    Reikning = tala1 + tala2;
                    rtbUtskrá.Text = Reikning.ToString();

                }
                
            }
            if (adferd == "-")
            {
                Reikning = tala1 - tala2;
                rtbUtskrá.Text = Reikning.ToString();
            }
            if (adferd == "*")
            {
                Reikning = tala1 * tala2;
                rtbUtskrá.Text = Reikning.ToString();
            }
            if (adferd == "/")
            {
                Reikning = tala1 / tala2;
                rtbUtskrá.Text = Reikning.ToString();
            }
            if (adferd == "%")
            {
                Reikning = tala1 * (tala2/100);
                rtbUtskrá.Text = Reikning.ToString();
            }
            if (adferd == "x^x")
            {
                Reikning = tala1;
                for (int i = 1; i < tala2; i++)
                {
                    Reikning = Reikning * tala1;
                }
                
                rtbUtskrá.Text = Reikning.ToString();
            }
            
            //seinnihluta = null;
            //firsthluta = null;
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear();
            firsthluta = input;
            input = null;
            adferd = "-";
        }

        private void btMargfoldun_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear();
            firsthluta = input;
            input = null;
            adferd = "*";
        }

        private void btDeiling_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear();
            firsthluta = input;
            input = null;
            adferd = "/";
        }

        private void btProsent_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear();
            firsthluta = input;
            input = null;
            adferd = "%";
        }

        private void btXiveldiX_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear();
            firsthluta = input;
            input = null;
            adferd = "x^x";
        }

        private void btXiordu_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear();
            firsthluta = input;
            input = null;
            adferd = "x^2";
            double.TryParse(firsthluta, out tala1);
            Reikning = tala1 * tala1;
            rtbUtskrá.Text = Reikning.ToString();
        }

        private void btMplus_Click(object sender, EventArgs e)
        {
            memorie = memorie + Convert.ToDouble(input);

        }

        

        

        
    }
}
