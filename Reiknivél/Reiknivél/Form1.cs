using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Reiknivél
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------
        string input = null; //Geymir það sem er skrifað inn í reiknivelinn
        string firsthluta = null; //Til að geymir það sem er skrifað fyrst inn í reiknivelinn áður en það er valið aðferð.
        string seinnihluta = null; // -||- nema það geymir seinni
        string adferd = null; //Til að velja adferð sem reiknivelinn notar
        //---------------------
        double Reikning = 0; //Reiknir saman firsthluta og seinnihluta
        double tala1 = 0, tala2 = 0; //tala1 og tala2 notaðir til að breyta string firsthluta og seinnihluta í double tölur
        double memorie = 0; //Fyrir M+,M- og MR takkarnir
        string tempdel = null; //Til að bakka ein tala í reiknivelin
        //---------------------
        //Virkja Alla Takkanir(Allir með nokkuð eins skipanir)
        private void bt1_Click(object sender, EventArgs e)
        {
            
            rtbUtskrá.Text += "1";  //Synir 1 á skjárinn
            input += "1";   //Geymir 1(þegar það er ýtt á 1) í input
            
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
        //-------------------------------
        //btC: Til að nulla allt til að endursetja reiknivelinn
        private void btC_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear(); //Clearar Skjárinn
            input = null; //Nullar inputið
            firsthluta = null; //Nullar firsthluta
            seinnihluta = null; //Nullar seinnihluta
        }
        //btDEL: Til að fara til um ein í reiknivelinn
        private void btDel_Click(object sender, EventArgs e)
        {
            tempdel = input.Substring(0, (input.Length - 1)); //tekur inn inputið og tekur í burtu ein
            input = tempdel; //Tekur tempdel og færi það yfir í input
            rtbUtskrá.Clear(); //Clearar Skjárinn
            rtbUtskrá.Text = input; //Sýnir inputið á skjárinn
        }
        //btCE: Clearar skjárinn og inputið
        private void btCE_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear(); //Clearar skjárinn
            input = null; //nullar/Clearar inputið
        }
        //btPlus: Virka Aðferðinn +
        private void btPlus_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear();
            firsthluta = input; //geymir inputið í firsthluta
            input = null; //Nullar inputið
            adferd = "+"; //Gefur adferd +
            
        }

        private void btKomma_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Text += ",";
            input += ",";
        }
        //btReina: Reiknir saman firsthluta og seinnihluta og sýnir það á skjárinn
        private void btReikna_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear(); //Clearar skjárinn
            seinnihluta = input; //Geymir inputið í seinnihluta
            input = null; // nullar inputið
            double.TryParse(firsthluta, out tala1); //breytir firsthluta(string) í tala1(double)
            double.TryParse(seinnihluta, out tala2); //breytir seinnihluta(string) í tala2(double)
            if (adferd == "+") //Skoðar ef aðferðinn er +
            {
                if (tala2 == 0)//Virkar ekki
                {
                    Reikning = Reikning + tala1;
                    rtbUtskrá.Text = Reikning.ToString();
                }
                else//Virkar
                {
                    Reikning = tala1 + tala2; //Reiknir saman tala1 og tala 2
                    rtbUtskrá.Text = Reikning.ToString(); //Sýnir á skjárinn

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
        //----------------------
        //Geri það sama og btPlus nema með annar adferd
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
        //-------------------------------
        //btX: notar bara firsthluta til að reyna talan í öðru veldi
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

        private void btMminus_Click(object sender, EventArgs e)
        {
            memorie = memorie - Convert.ToDouble(input);
        }

        private void btMresult_Click(object sender, EventArgs e)
        {
            rtbUtskrá.Clear();
            rtbUtskrá.Text = memorie.ToString();
        }
        //btSkraitextaskra: skrái inn i textaskra
        private void btSkraitextaskra_Click(object sender, EventArgs e)
        {
            try//Reynir aðferð
            {
                StreamWriter skrifari = File.AppendText("Textskra.txt"); //opnar skráinn til að breyta í honum
                skrifari.WriteLine(firsthluta + " " + adferd + " " + seinnihluta + " = " + Reikning); //setur inn firsthluta,adferd,seinnihluta og reikninginn inn
                skrifari.Close(); //lokar skráinn
            }
            catch (Exception ex) //ef það virkar ekki
            {
                MessageBox.Show("Ekki tókst að opna skránna" + ex);
            }
        }
        //deletear txt skrá og býr til nýan þegar það er kveikt á verkefni
        private void Form1_Load(object sender, EventArgs e)
        {
            File.Delete("Textskra.txt");//Deletar txt skráinn
            BuaTilSkra(); //Býr til nýan skrá
        }
        //aðferðinn buatilskra
        private void BuaTilSkra()
        {
            StreamWriter Skrifari = new StreamWriter("Textskra.txt");//Býr til textskra.txt
            Skrifari.Close(); //lokar skrifarinn
        }

        

        

        
    }
}
