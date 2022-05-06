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
    public partial class Pool3 : UserControl
    {
        private static Pool3 _instance;
        private Form1 _parent = null;
        int ID;
        Color zelena = Color.FromArgb(51, 255, 51);
        Color cervena = Color.FromArgb(255, 51, 51);
        Color zluta = Color.FromArgb(255, 255, 102);
        Label[] Napomenuti = new Label[6];
        Label[] Jmeno = new Label[6];
        TableLayoutPanel[] Pozadi = new TableLayoutPanel[6];
        Button[] UkoncovaciTlacitka = new Button[3];
        Button[] HodnoticiTlacitka = new Button[6];
        Label[] Vysledky = new Label[6];

        bool read;

        public static Pool3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Pool3();
                return _instance;
            }
        }

        public void setParent(Form1 uk)
        {
            _parent = uk;
        }

        public Pool3()
        {
            InitializeComponent();
            Napomenuti[0] = this.napomenuti1;
            Napomenuti[1] = this.napomenuti2;
            Napomenuti[2] = this.napomenuti3;
            Napomenuti[3] = this.napomenuti4;
            Napomenuti[4] = this.napomenuti5;
            Napomenuti[5] = this.napomenuti6;

            Jmeno[0] = this.jmeno11;
            Jmeno[1] = this.jmeno12;
            Jmeno[2] = this.jmeno21;
            Jmeno[3] = this.jmeno22;
            Jmeno[4] = this.jmeno31;
            Jmeno[5] = this.jmeno32;

            Pozadi[0] = this.tableLayout11;
            Pozadi[1] = this.tableLayout12;
            Pozadi[2] = this.tableLayout21;
            Pozadi[3] = this.tableLayout22;
            Pozadi[4] = this.tableLayout31;
            Pozadi[5] = this.tableLayout32;

            UkoncovaciTlacitka[0] = this.stav1;
            UkoncovaciTlacitka[1] = this.stav2;
            UkoncovaciTlacitka[2] = this.stav3;

            HodnoticiTlacitka[0] = this.hodnotit1;
            HodnoticiTlacitka[1] = this.hodnotit2;
            HodnoticiTlacitka[2] = this.hodnotit3;
            HodnoticiTlacitka[3] = this.hodnotit4;
            HodnoticiTlacitka[4] = this.hodnotit5;
            HodnoticiTlacitka[5] = this.hodnotit6;

            Vysledky[0] = this.body1;
            Vysledky[1] = this.body2;
            Vysledky[2] = this.body3;
            Vysledky[3] = this.body4;
            Vysledky[4] = this.body5;
            Vysledky[5] = this.body6;
            

            read = false;

        }

        private void navratKZapasu_Click(object sender, EventArgs e)
        {
            _parent.Zobrazovac("Turnaj");
        }

        public void set(int poolNo)
        {
            read = false;
            infoPopisek.Text = "POOL " + Convert.ToString(poolNo);
            ID = _parent.pooly.Count() - poolNo;
            
            Jmeno[0].Text  = _parent.pooly[ID].zapasnici[0].jmeno + " " + _parent.pooly[ID].zapasnici[0].prijmeni;
            Jmeno[1].Text = _parent.pooly[ID].zapasnici[1].jmeno + " " + _parent.pooly[ID].zapasnici[1].prijmeni;
            Jmeno[2].Text = _parent.pooly[ID].zapasnici[1].jmeno + " " + _parent.pooly[ID].zapasnici[1].prijmeni;
            Jmeno[3].Text = _parent.pooly[ID].zapasnici[2].jmeno + " " + _parent.pooly[ID].zapasnici[2].prijmeni;
            Jmeno[4].Text = _parent.pooly[ID].zapasnici[2].jmeno + " " + _parent.pooly[ID].zapasnici[2].prijmeni;
            Jmeno[5].Text = _parent.pooly[ID].zapasnici[0].jmeno + " " + _parent.pooly[ID].zapasnici[0].prijmeni;

                
            vykresli();
            read = true;
        }


        public void vykresli()
        { 

            for (int i = 0; i < 6; i++)
            {
                HodnoticiTlacitka[i].Enabled = true;
                int idZapasuProtihrace = 0;
                if (i == 0) {idZapasuProtihrace = 1; }
                else if (i == 1) {idZapasuProtihrace = 0; }
                else if (i == 2) {idZapasuProtihrace = 3; }
                else if (i == 3) {idZapasuProtihrace = 2; }
                else if (i == 4) {idZapasuProtihrace = 5; }
                else if (i == 5) {idZapasuProtihrace = 4; }


                if (_parent.pooly[ID].vysledky[i + 6] != '0')
                {
                    Vysledky[i].Text = (Convert.ToString(_parent.pooly[ID].vysledky[i]) +" "+ Convert.ToString(_parent.pooly[ID].vysledky[i + 6])).ToUpper();
                }
                else if (_parent.pooly[ID].vysledky[i] != '0')
                {
                    Vysledky[i].Text = Convert.ToString(_parent.pooly[ID].vysledky[i]).ToUpper();
                }
                else
                {
                        Vysledky[i].Text = "";
                }

                Vysledky[i].Text = Vysledky[i].Text.Replace("H", "Ht");

                for(int y = 0; y < _parent.pooly[ID].napomenuti[idZapasuProtihrace]/2; y++)
                {
                    Vysledky[i].Text += " H";
                }


                Napomenuti[i].Text = "";
                int pomNapomenuti = _parent.pooly[ID].napomenuti[i];
                if (pomNapomenuti >= 2)
                {
                    pomNapomenuti = pomNapomenuti - 2;
                }
                for(int y = 0; y < pomNapomenuti; y++)
                {
                    Napomenuti[i].Text += "▲";
                }
            }


            for(int i = 0; i < _parent.pooly[ID].vysledky.Count() / 4; i++)
            {
                if (_parent.pooly[ID].ukonceno[i] == false)
                {
                    UkoncovaciTlacitka[i].Text = "Ukončit";
                }
                else
                {
                    UkoncovaciTlacitka[i].Text = "Obnovit";
                    HodnoticiTlacitka[i * 2].Enabled = false;
                    HodnoticiTlacitka[i * 2 + 1].Enabled = false;
                }

                switch (_parent.pooly[ID].vyherce(i))
                {
                    case 0:
                        Jmeno[i * 2].BackColor = SystemColors.Control;
                        Jmeno[i * 2 + 1].BackColor = SystemColors.Control;

                        Pozadi[i * 2].BackColor = SystemColors.Control;
                        Pozadi[i * 2 + 1].BackColor = SystemColors.Control;
                        break;
                    case 1:
                        Jmeno[i * 2].BackColor = zelena;
                        Jmeno[i * 2 + 1].BackColor = cervena;

                        Pozadi[i * 2].BackColor = zelena;
                        Pozadi[i * 2 + 1].BackColor = cervena;
                        break;
                    case 2:
                        Jmeno[i * 2].BackColor = cervena;
                        Jmeno[i * 2 + 1].BackColor = zelena;

                        Pozadi[i * 2].BackColor = cervena;
                        Pozadi[i * 2 + 1].BackColor = zelena;
                        break;
                    case 3:
                        Jmeno[i * 2].BackColor = zluta;
                        Jmeno[i * 2 + 1].BackColor = zluta;

                        Pozadi[i * 2].BackColor = zluta;
                        Pozadi[i * 2 + 1].BackColor = zluta;
                        break;
                }
            }


        }

        private void stav1_Click(object sender, EventArgs e)
        {
            ukoncitObnovit(0);
        }

        private void stav2_Click(object sender, EventArgs e)
        {
            ukoncitObnovit(1);
        }

        private void stav3_Click(object sender, EventArgs e)
        {
            ukoncitObnovit(2);
        }

        private void ukoncitObnovit(int poradi)
        {
            if (_parent.pooly[ID].ukonceno[poradi] == false)
            {
                _parent.pooly[ID].ukonceno[poradi] = true;
            }
            else
            {
                _parent.pooly[ID].ukonceno[poradi] = false;
            }
            vykresli();
            //MessageBox.Show(Convert.ToString(_parent.pooly[ID].ukonceno[0]) + " " + Convert.ToString(_parent.pooly[ID].ukonceno[1]) + " " + Convert.ToString(_parent.pooly[ID].ukonceno[2]));
        }

        private void hodnotit1_Click(object sender, EventArgs e)
        {
            _parent.Zobrazovac("Hodnoceni", ID, 0);
        }

        private void hodnotit2_Click(object sender, EventArgs e)
        {
            _parent.Zobrazovac("Hodnoceni", ID, 1);
        }

        private void hodnotit3_Click(object sender, EventArgs e)
        {
            _parent.Zobrazovac("Hodnoceni", ID, 2);
        }

        private void hodnotit4_Click(object sender, EventArgs e)
        {
            _parent.Zobrazovac("Hodnoceni", ID, 3);
        }

        private void hodnotit5_Click(object sender, EventArgs e)
        {
            _parent.Zobrazovac("Hodnoceni", ID, 4);
        }

        private void hodnotit6_Click(object sender, EventArgs e)
        {
            _parent.Zobrazovac("Hodnoceni", ID, 5);
        }
    }
}
