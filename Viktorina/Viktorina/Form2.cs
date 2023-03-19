﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viktorina
{

    public partial class Form2 : Form
    {
        void Sajaukt()
        {
            var rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next(25);
                int y = rand.Next(25);
                string pag = jautajumi[x];
                jautajumi[x] = jautajumi[y];
                jautajumi[y] = pag;
            }

            string[] jautajumi = new string[] {
            jautajumi[0] ="KAD LATVIJĀ TIEK SVINĒTI DARBA SVĒTKI?",
            "KAD LATVIJĀ TIEK SVINĒTS LATVIJAS REPUBLIKAS NEATKARĪBAS ATJAUNOŠANAS DIENA?",
            "KAD LATVIJĀ TIEK SVINĒTS LIGO?",
            "KAS TIEK SVINĒTS 18. NOVEMBRĪ?",
            "KAS TIEK SVINĒTS 17. JŪNIJĀ?",
            "KAS TIEK SVINĒTS 1. JŪNIJĀ?",
            "KĀ SAUC LATVIJAS LIELĀKO UPI?",
            "KĀ SAUC LATVIJAS GALVASPILSĒTU?",
            "KĀ SAUC LATVIJAS GARĀKO UPI?",
            "KĀ SAUC LATVIJAS AUGSTĀKO KALNU?",
            "APTUVENI, CIK LATVIJĀ IR IEDZĪVOTĀJU?",
            "KURA IR LATVIJAS VECĀKĀ PILSĒTA?",
            "ŪDENSKRITUMS VENTAS RUMBA, KAS ATRODAS KULDĪGĀ IR:",
            "KĀ SAUC BRĪVĪBAS PIEMINEKĻA AUTORU?",
            "KAS IR LATVIJAS HIMNAS AUTORS?",
            "KĀ SAUC LATVIJAS PIRMO PREZIDENTU!",
            "KURĀ GADĀ DIBINĀTA LATVIJAS VALSTS?",
            "KAD NOTIKA PIRMIE VISPĀRĒJIE LATVIEŠU DZIESMU SVĒTKI?",
            "KO LATVIJĀ ATZĪMĒ 11. NOVEMBRĪ?",
            "TV TORNIS, KAS ATRODAS ZAĶUSALĀ IR:",
            "AR KĀDU DABAS RESURSU LATVIJA IR VISBAGĀTĀKĀ?",
            "LATVIJĀ DZIMUŠAIS JĀKOBS JUFESS PASAULĒ IR ZINĀMS AR TO, KA:",
            "NOSAUC LATVIJAS DZIĻĀKO EZERU!",
            "KĀ SAUC JŪRU, PIE KURAS ATRODAS LATVIJA?",
            "KAS IR LATVIJAS VALSTS LIKUMDEVĒJS?",
            "1999. GADĀ PAR LATVIJAS PREZIDENTI KĻUVA VAIRA VĪĶE – FREIBERGA. UZ TO BRĪDI VIŅA BIJA PIRMĀ SIEVIETE PREZIDENTE:"  };


        }




        void parbaude()
        {
            string[] atbildes1 = new string[] {
            "1. maijā",
            "25. aprīlī",
            "22 – 23. jūnijā",
            "Latvijas Republikas neatkarības atjaunošanas diena",
            "Latvijas Republikas okupācijas diena ",
            "Starptautiskā bērnu aizsardzības diena ",
            "Daugava",
            "Liepāja",
            "Lielupe",
            "Gaiziņkalns",
            "1 miljons",
            "Rīga",
            "Vecākais ūdenskritums Eiropā",
            "Kārlis Zāle",
            "Kārlis Zāle",
            "Jānis Čakste",
            "1920. gadā",
            "1873. gadā",
            "Līgo svētkus",
            "Visaugstākais tornis Eiropā",
            "Ūdens",
            "Viņš izgudroja kafiju",
            "Alūksnes ezers",
            "Rīgas jūras līcis",
            "Prezidents",
            "Eiropā"
        };
            string[] atbildes2 = new string[] {
            "4. maijā",
            "3. maijā",
            "23—24. Jūnijā",
            " Latvijas Republikas Proklamēšanas diena ",
            " ugunsdzēsēju un glābēju diena",
            " Starptautiskā ģimenes diena ",
            "Lielupe",
            "Daugavpils",
            "Daugava",
            "Mākoņkalns",
            "2 miljoni",
            "Ludza",
            "Skaistākais ūdenskritums Eiropā",
            "Baumaņu Kārlis",
            "Jāzeps Vītols",
            "Guntis Ulmanis",
            "1918. gadā",
            "1973. gadā",
            "Latvijas dzimšanas dienu",
            "Otrais augstākais tornis Eiropā",
            "Mežs",
            "Viņš izgudroja radio",
            "Burtnieku ezers",
            "Baltā jūra",
            "Ministri",
            "Austrumeiropā"
        };
            string[] atbildes3 = new string[] {
            "3. jūnijā ",
            "4 maijā ",
            "29. jūnijā ",
            "Latvijas Republikas okupācijas diena ",
            "Latvijas brīvības cīnītāju piemiņas diena ",
            "Medicīnas darbinieku diena ",
            "Gauja",
            "Rīga",
            "Gauja",
            "Zilaiskalns",
            "3 miljoni",
            "Grobiņa",
            "Platākais ūdenskritums Eiropā",
            "Krišjānis Barons",
            "Baumaņu Kārlis",
            "Kārlis Ulmanis",
            "1919. gadā",
            "2003. gadā",
            "Lāčplēša dienu",
            "Trešais augstākais tornis Eiropā",
            "Māls",
            "Viņš izgudroja džinsus",
            "Drīdzis",
            "Baltijas jūra",
            "Saeima",
            "Baltijā"
        };
            string[] atbildes = new string[] {
            "1. maijā",
            "4 maijā",
            "23—24. Jūnijā",
            "Latvijas Republikas Proklamēšanas diena",
            "Latvijas Republikas okupācijas diena",
            "Starptautiskā bērnu aizsardzības diena",
            "Daugava",
            "Rīga",
            "Gauja",
            "Gaiziņkalns",
            "2 miljoni",
            "Ludza",
            "Platākais ūdenskritums Eiropā",
            "Kārlis Zāle",
            "Baumaņu Kārlis",
            "Jānis Čakste",
            "1918. gadā",
            "1873. gadā",
            "Lāčplēša dienu",
            "Trešais augstākais tornis Eiropā",
            "Mežs",
            "Viņš izgudroja džinsus",
            "Drīdzis",
            "Baltijas jūra",
            "Saeima",
            "Austrumeiropā"
        };
        }





        public static int punkti = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labJautajums.Text = jautajumi[piemeri];
            butAtbilde1.Text = atbildes1[piemeri];
            butAtbilde2.Text = atbildes2[piemeri];
            butAtbilde3.Text = atbildes3[piemeri];
        }

        private void butAtbilde1_Click(object sender, EventArgs e)
        {
            if (butAtbilde1.Text == atbildes[piemeri]) punkti = punkti + 1;
            else if (punkti > 0) punkti = punkti - 1;
            if (punkti == 1) labPunkti.Text = punkti + " punkts";
            else labPunkti.Text = punkti + " punkti";
            piemeri = piemeri + 1;
            if (piemeri < 10)
            {
                labJautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                labPiemers.Text = (piemeri + 1) + ". no 10 jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }

        private void butAtbilde2_Click(object sender, EventArgs e)
        {
            if (butAtbilde2.Text == atbildes[piemeri]) punkti = punkti + 1;
            else if (punkti > 0) punkti = punkti - 1;
            if (punkti == 1) labPunkti.Text = punkti + " punkts";
            else labPunkti.Text = punkti + " punkti";
            piemeri = piemeri + 1;
            if (piemeri < 10)
            {
                labJautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                labPiemers.Text = (piemeri + 1) + ". no 10 jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }

        private void butAtbilde3_Click(object sender, EventArgs e)
        {
            if (butAtbilde3.Text == atbildes[piemeri]) punkti = punkti + 1;
            else if (punkti > 0) punkti = punkti - 1;
            if (punkti == 1) labPunkti.Text = punkti + " punkts";
            else labPunkti.Text = punkti + " punkti";
            piemeri = piemeri + 1;
            if (piemeri < 10)
            {
                labJautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                labPiemers.Text = (piemeri + 1) + ". no 10 jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }



    }

}

