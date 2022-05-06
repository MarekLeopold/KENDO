using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KENDO
{
    public partial class Hodnoceni : UserControl
    {
        private static Hodnoceni _instance;
        private Form1 _parent = null;
        int ID = 0;
        int hrac = 0;
        Button[] hodnoceniHrace = new Button[10];

        public Hodnoceni()
        {
            InitializeComponent();
            hodnoceniHrace[0] = this.m1;
            hodnoceniHrace[1] = this.m2;
            hodnoceniHrace[2] = this.k1;
            hodnoceniHrace[3] = this.k2;
            hodnoceniHrace[4] = this.d1;
            hodnoceniHrace[5] = this.d2;
            hodnoceniHrace[6] = this.t1;
            hodnoceniHrace[7] = this.t2;
            hodnoceniHrace[8] = this.h1;
            hodnoceniHrace[9] = this.h2;


        }
            
        public static Hodnoceni Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Hodnoceni();
                return _instance;
            }
        }

        public void setParent(Form1 uk)
        {
            _parent = uk;
        }

        public void set(int ID, int hrac)
        {
            this.ID = ID;
            this.hrac = hrac;
            vykresli();
        }

        public void vykresli()
        {

            m1.Text = "M";
            m2.Text = "M";
            k1.Text = "K";
            k2.Text = "K";
            d1.Text = "D";
            d2.Text = "D";
            t1.Text = "T";
            t2.Text = "T";
            h1.Text = "Ht";
            h2.Text = "Ht";


            for (int i = 0; i < 10; i++)
            {
                
                if (i % 2 == 1 && _parent.pooly[ID].vysledky[hrac] == '0') {
                    ((Button)hodnoceniHrace[i]).Enabled = false;
                    ((Button)hodnoceniHrace[i]).BackColor = Color.Gray;
                }
                else
                {
                    ((Button)hodnoceniHrace[i]).Enabled = true;
                    ((Button)hodnoceniHrace[i]).BackColor = Color.White;
                }

            }

            int tentoHrac = 0;
            int vsHrac = 0;
            int idZapasuProtihrace = 0;


            // 0 vs 1  // 0 vs 1
            // 1 vs 2  // 2 vs 3
            // 2 vs 0  // 4 vs 5

            if (hrac == 0) { tentoHrac = 0; vsHrac = 1; idZapasuProtihrace = 1; }
            else if(hrac == 1) { tentoHrac = 1; vsHrac = 0; idZapasuProtihrace = 0; }
            else if(hrac == 2) { tentoHrac = 1; vsHrac = 2; idZapasuProtihrace = 3; }
            else if (hrac == 3) { tentoHrac = 2; vsHrac = 1; idZapasuProtihrace = 2; }
            else if (hrac == 4) { tentoHrac = 2; vsHrac = 0; idZapasuProtihrace = 5; }
            else if (hrac == 5) { tentoHrac = 0; vsHrac = 2; idZapasuProtihrace = 4; }

            popisekHodnoceni.Text = "Hodnocení hráče "+_parent.pooly[ID].zapasnici[tentoHrac].jmeno+" "+ _parent.pooly[ID].zapasnici[tentoHrac].prijmeni;
            popisekSouboj.Text = "V turnaji " + _parent.pooly[ID].zapasnici[tentoHrac].jmeno + " " + _parent.pooly[ID].zapasnici[tentoHrac].prijmeni + " vs " + _parent.pooly[ID].zapasnici[vsHrac].jmeno + " " + _parent.pooly[ID].zapasnici[vsHrac].prijmeni;

            switch (_parent.pooly[ID].vysledky[hrac])
            {
                case 'm':
                    m1.BackColor = Color.Green;
                    break;
                case 'k':
                    k1.BackColor = Color.Green;
                    break;
                case 'd':
                    d1.BackColor = Color.Green;
                    break;
                case 't':
                    t1.BackColor = Color.Green;
                    break;
                case 'h':
                    h1.BackColor = Color.Green;
                    break;
            }

            switch (_parent.pooly[ID].vysledky[hrac+6])
            {
                case 'm':
                    m2.BackColor = Color.Green;
                    break;
                case 'k':
                    k2.BackColor = Color.Green;
                    break;
                case 'd':
                    d2.BackColor = Color.Green;
                    break;
                case 't':
                    t2.BackColor = Color.Green;
                    break;
                case 'h':
                    h2.BackColor = Color.Green;
                    break;
            }

            napomenuti.Text = "";
            int napomenutiPom = _parent.pooly[ID].napomenuti[hrac];
            if(napomenutiPom >= 2)
            {
                napomenutiPom = napomenutiPom - 2;
            }
            for (int i = 0; i < napomenutiPom; i++)
            {
                napomenuti.Text += "▲";
            }

            if(_parent.pooly[ID].napomenuti[hrac] >= 2)
            {
                infoOBodu.Text = "Protihráči byl udělený bod za napomenutí !";
            }
            else
            {
                infoOBodu.Text = "";
            }

            if(_parent.pooly[ID].napomenuti[idZapasuProtihrace] >= 2)
            {
                m2.Text = "H";
                k2.Text = "H";
                d2.Text = "H";
                t2.Text = "H";
                h2.Text = "H";

                m2.Enabled = false;
                k2.Enabled = false;
                d2.Enabled = false;
                t2.Enabled = false; 
                h2.Enabled = false;

                m2.BackColor = Color.Green;
                k2.BackColor = Color.Green;
                d2.BackColor = Color.Green;
                t2.BackColor = Color.Green;
                h2.BackColor = Color.Green;
            }

            if (_parent.pooly[ID].napomenuti[idZapasuProtihrace] >= 4)
            {
                m1.Text = "H";
                k1.Text = "H";
                d1.Text = "H";
                t1.Text = "H";
                h1.Text = "H";

                m1.Enabled = false;
                k1.Enabled = false;
                d1.Enabled = false;
                t1.Enabled = false;
                h1.Enabled = false;

                m1.BackColor = Color.Green;
                k1.BackColor = Color.Green;
                d1.BackColor = Color.Green;
                t1.BackColor = Color.Green;
                h1.BackColor = Color.Green;
            }

        }

        private void zpet_Click(object sender, EventArgs e)
        {
            _parent.Zobrazovac("Pool3");
            vykresli();
        }

        private void m1_Click(object sender, EventArgs e)
        {
            setClick('m', 0);
        }

        private void k1_Click(object sender, EventArgs e)
        {
            setClick('k', 0);
        }

        private void d1_Click(object sender, EventArgs e)
        {
            setClick('d', 0);
        }

        private void t1_Click(object sender, EventArgs e)
        {
            setClick('t', 0);
        }

        private void h1_Click(object sender, EventArgs e)
        {
            setClick('h', 0);
        }

        private void m2_Click(object sender, EventArgs e)
        {
            setClick('m', 1);
        }

        private void k2_Click(object sender, EventArgs e)
        {
            setClick('k', 1);
        }

        private void d2_Click(object sender, EventArgs e)
        {
            setClick('d', 1);
        }

        private void t2_Click(object sender, EventArgs e)
        {
            setClick('t', 1);
        }

        private void h2_Click(object sender, EventArgs e)
        {
            setClick('h', 1);
        }

        private void setClick(char hodnoceni, int radek)
        {
            // radek 0, 1
            // nulování hodnocení (pokud bylo kliknuto na stejné políčko, bude hodnocení smazáno
            if (_parent.pooly[ID].vysledky[hrac + radek * 6] == hodnoceni)
            {
                _parent.pooly[ID].vysledky[hrac + radek * 6] = '0';
            }
            else{
                _parent.pooly[ID].vysledky[hrac + radek * 6] = hodnoceni;
            }

            // změna pořadí hodnocení jediný bod bude vždy 1. bod
            if( _parent.pooly[ID].vysledky[hrac] == '0' && _parent.pooly[ID].vysledky[hrac + 6] != '0')
            {
                _parent.pooly[ID].vysledky[hrac] = _parent.pooly[ID].vysledky[hrac + 6];
                _parent.pooly[ID].vysledky[hrac + 6] = '0';
            }

            vykresli();
        }

        private void NapomenutiUdelit_Click(object sender, EventArgs e)
        {
            if(_parent.pooly[ID].napomenuti[hrac] < 4)
            {
                _parent.pooly[ID].napomenuti[hrac]++;
            }
            vykresli();
        }

        private void NapomenutiOdebrat_Click(object sender, EventArgs e)
        {
            if (_parent.pooly[ID].napomenuti[hrac] > 0)
            {
                _parent.pooly[ID].napomenuti[hrac]--;
            }
            vykresli();
        }
    }
}
