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
        ComboBox[] Vysledky = new ComboBox[6];
        Label[] Napomenuti = new Label[6];
        Label[] Oznameni = new Label[6];
        Label[] Jmeno = new Label[6];
        Button[] NapomenutiAddBtn = new Button[6];
        Button[] NapomenutiRemBtn = new Button[6];
        TableLayoutPanel[] Pozadi = new TableLayoutPanel[6];
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
            Vysledky[0] = this.vysledek11;
            Vysledky[1] = this.vysledek12;
            Vysledky[2] = this.vysledek21;
            Vysledky[3] = this.vysledek22;
            Vysledky[4] = this.vysledek31;
            Vysledky[5] = this.vysledek32;

            Napomenuti[0] = this.napomenuti1;
            Napomenuti[1] = this.napomenuti2;
            Napomenuti[2] = this.napomenuti3;
            Napomenuti[3] = this.napomenuti4;
            Napomenuti[4] = this.napomenuti5;
            Napomenuti[5] = this.napomenuti6;

            Oznameni[0] = this.oznameni1;
            Oznameni[1] = this.oznameni2;
            Oznameni[2] = this.oznameni3;
            Oznameni[3] = this.oznameni4;
            Oznameni[4] = this.oznameni5;
            Oznameni[5] = this.oznameni6;

            Jmeno[0] = this.jmeno11;
            Jmeno[1] = this.jmeno12;
            Jmeno[2] = this.jmeno21;
            Jmeno[3] = this.jmeno22;
            Jmeno[4] = this.jmeno31;
            Jmeno[5] = this.jmeno32;

            NapomenutiAddBtn[0] = this.napomenutiAdd1;
            NapomenutiAddBtn[1] = this.napomenutiAdd2;
            NapomenutiAddBtn[2] = this.napomenutiAdd3;
            NapomenutiAddBtn[3] = this.napomenutiAdd4;
            NapomenutiAddBtn[4] = this.napomenutiAdd5;
            NapomenutiAddBtn[5] = this.napomenutiAdd6;

            NapomenutiRemBtn[0] = this.napomenutiRem1;
            NapomenutiRemBtn[1] = this.napomenutiRem2;
            NapomenutiRemBtn[2] = this.napomenutiRem3;
            NapomenutiRemBtn[3] = this.napomenutiRem4;
            NapomenutiRemBtn[4] = this.napomenutiRem5;
            NapomenutiRemBtn[5] = this.napomenutiRem6;

            Pozadi[0] = this.tableLayout11;
            Pozadi[1] = this.tableLayout12;
            Pozadi[2] = this.tableLayout21;
            Pozadi[3] = this.tableLayout22;
            Pozadi[4] = this.tableLayout31;
            Pozadi[5] = this.tableLayout32;

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

            for (int i = 0; i < 6; i++)
            {
                Vysledky[i].SelectedIndex = 0;

            }

            //MessageBox.Show(_parent.pooly[ID].vysledky[0] + " / " + _parent.pooly[ID].vysledky[1] + " / " + _parent.pooly[ID].vysledky[2] + " / " + _parent.pooly[ID].vysledky[3] + " / " + _parent.pooly[ID].vysledky[4] + " / " + _parent.pooly[ID].vysledky[5]);
                for (int i = 0; i < 6; i++)
                {
                    Vysledky[i].SelectedIndex = prevadec(_parent.pooly[ID].vysledky[i]);
            
                }
                
            vykresli();
            read = true;
        }

        private void napomenuti(int pole, int inkrement)
        {
                _parent.pooly[ID].napomenuti[pole] = _parent.pooly[ID].napomenuti[pole] + inkrement;
                if(_parent.pooly[ID].napomenuti[pole] < 0)
                {
                    _parent.pooly[ID].napomenuti[pole] = 0;
                }
                if(_parent.pooly[ID].napomenuti[pole] > 2)
                {
                    _parent.pooly[ID].napomenuti[pole] = 2;
                }

            vykresli();
        }

        #region tlacitka napomenuti
        private void napomenutiAdd1_Click(object sender, EventArgs e)
        {
            napomenuti(0, 1);
        }

        private void napomenutiAdd2_Click(object sender, EventArgs e)
        {
            napomenuti(1, 1);
        }

        private void napomenutiAdd3_Click(object sender, EventArgs e)
        {
            napomenuti(2, 1);
        }

        private void napomenutiAdd4_Click(object sender, EventArgs e)
        {
            napomenuti(3, 1);
        }

        private void napomenutiAdd5_Click(object sender, EventArgs e)
        {
            napomenuti(4, 1);
        }

        private void napomenutiAdd6_Click(object sender, EventArgs e)
        {
            napomenuti(5, 1);
        }

        private void napomenutiRem1_Click(object sender, EventArgs e)
        {
            napomenuti(0, -1);
        }

        private void napomenutiRem2_Click(object sender, EventArgs e)
        {
            napomenuti(1, -1);
        }

        private void napomenutiRem3_Click(object sender, EventArgs e)
        {
            napomenuti(2, -1);
        }

        private void napomenutiRem4_Click(object sender, EventArgs e)
        {
            napomenuti(3, -1);
        }

        private void napomenutiRem5_Click(object sender, EventArgs e)
        {
            napomenuti(4, -1);
        }

        private void napomenutiRem6_Click(object sender, EventArgs e)
        {
            napomenuti(5, -1);
        }

        #endregion

        private void zpracujVysledek(object sender, EventArgs e)
        {
            if (read) { 
                for (int i = 0; i < 6; i++)
                {
                    _parent.pooly[ID].vysledky[i] = prevadec(Vysledky[i].SelectedIndex);
                }
            }
            vykresli();

        }

        private void vykresli()
        {
            for(int i = 0; i < 3; i++)
            {
                Napomenuti[i*2].Text = "";
                for(int j = 0; j < _parent.pooly[ID].napomenuti[i*2]; j++)
                {
                    Napomenuti[i*2].Text += "⚫";
                }

                Napomenuti[i*2+1].Text = "";
                for (int j = 0; j < _parent.pooly[ID].napomenuti[i*2+1]; j++)
                {
                    Napomenuti[i*2+1].Text += "⚫";
                }

                if(_parent.pooly[ID].napomenuti[i*2] >= 2) // vyhra praveho pomoci napomenuti
                {
                    Oznameni[i * 2 + 1].Text = "Kontumační výhra";
                    Oznameni[i * 2].Text = "Vyřazení";
                    Vysledky[i * 2].SelectedIndex = 0;
                    Vysledky[i * 2 + 1].SelectedIndex = 0;
                    Vysledky[i * 2].Enabled = false;
                    Vysledky[i * 2 + 1].Enabled = false;
                    NapomenutiAddBtn[i * 2].Enabled = false;
                    NapomenutiAddBtn[i * 2 + 1].Enabled = false;
                    NapomenutiRemBtn[i * 2 + 1].Enabled = false;
                    Jmeno[i * 2 + 1].BackColor = zelena;
                    Pozadi[i * 2 + 1].BackColor = zelena;
                    Jmeno[i * 2].BackColor = cervena;
                    Pozadi[i * 2].BackColor = cervena;
                }
                else if(_parent.pooly[ID].napomenuti[i * 2 + 1] >= 2) // vyhra leveho
                {
                    Oznameni[i * 2].Text = "Kontumační výhra";
                    Oznameni[i * 2+1].Text = "Vyřazení za napomenutí";
                    Vysledky[i * 2+1].SelectedIndex = 0;
                    Vysledky[i * 2].SelectedIndex = 0;
                    Vysledky[i * 2+1].Enabled = false;
                    Vysledky[i * 2].Enabled = false;
                    NapomenutiAddBtn[i * 2+1].Enabled = false;
                    NapomenutiAddBtn[i * 2].Enabled = false;
                    NapomenutiRemBtn[i * 2].Enabled = false;
                    Jmeno[i * 2].BackColor = zelena;
                    Pozadi[i * 2].BackColor = zelena;
                    Jmeno[i * 2+1].BackColor = cervena;
                    Pozadi[i * 2+1].BackColor = cervena;
                }
                else if (prevadec(_parent.pooly[ID].vysledky[i*2]) != 0 && prevadec(_parent.pooly[ID].vysledky[i * 2]) != 5) // vyhra leveho
                {
                    Oznameni[i * 2].Text = "Výhra";
                    Oznameni[i * 2 + 1].Text = "Prohra";
                    Vysledky[i * 2 + 1].SelectedIndex = 0;
                    Vysledky[i * 2 + 1].Enabled = false;
                    Vysledky[i * 2].Enabled = true;
                    NapomenutiAddBtn[i * 2 + 1].Enabled = false;
                    NapomenutiRemBtn[i * 2 + 1].Enabled = false;
                    NapomenutiAddBtn[i * 2].Enabled = false;
                    NapomenutiRemBtn[i * 2].Enabled = false;
                    Jmeno[i * 2].BackColor = zelena;
                    Pozadi[i * 2].BackColor = zelena;
                    Jmeno[i * 2 + 1].BackColor = cervena;
                    Pozadi[i * 2 + 1].BackColor = cervena;
                }
                else if (prevadec(_parent.pooly[ID].vysledky[i * 2 + 1]) != 0 && prevadec(_parent.pooly[ID].vysledky[i * 2 + 1]) != 5) // vyhra praveho
                {
                    Oznameni[i * 2 + 1].Text = "Výhra";
                    Oznameni[i * 2].Text = "Prohra";
                    Vysledky[i * 2].SelectedIndex = 0;
                    Vysledky[i * 2].Enabled = false;
                    Vysledky[i * 2 + 1].Enabled = true;
                    NapomenutiAddBtn[i * 2].Enabled = false;
                    NapomenutiRemBtn[i * 2].Enabled = false;
                    NapomenutiAddBtn[i * 2 + 1].Enabled = false;
                    NapomenutiRemBtn[i * 2 + 1].Enabled = false;
                    Jmeno[i * 2 + 1].BackColor = zelena;
                    Pozadi[i * 2 + 1].BackColor = zelena;
                    Jmeno[i * 2].BackColor = cervena;
                    Pozadi[i * 2].BackColor = cervena;
                }
                else if(prevadec(_parent.pooly[ID].vysledky[i * 2 + 1]) == 5 || prevadec(_parent.pooly[ID].vysledky[i * 2]) == 5) // remíza
                {
                    Oznameni[i * 2 + 1].Text = "Remíza";
                    Oznameni[i * 2].Text = "Remíza";
                    Vysledky[i * 2].SelectedIndex = 5;
                    Vysledky[i * 2].Enabled = true;
                    Vysledky[i * 2 + 1].SelectedIndex = 5;
                    Vysledky[i * 2 + 1].Enabled = true;
                    NapomenutiAddBtn[i * 2].Enabled = false;
                    NapomenutiRemBtn[i * 2].Enabled = false;
                    NapomenutiAddBtn[i * 2 + 1].Enabled = false;
                    NapomenutiRemBtn[i * 2 + 1].Enabled = false;
                    Jmeno[i * 2 + 1].BackColor = zluta;
                    Pozadi[i * 2 + 1].BackColor = zluta;
                    Jmeno[i * 2].BackColor = zluta;
                    Pozadi[i * 2].BackColor = zluta;
                }
                else
                {
                    Oznameni[i * 2 + 1].Text = "";
                    Oznameni[i * 2].Text = "";
                    Vysledky[i * 2].Enabled = true;
                    Vysledky[i * 2 + 1].Enabled = true;
                    Vysledky[i * 2].SelectedIndex = 0;
                    Vysledky[i * 2 + 1].SelectedIndex = 0;
                    NapomenutiAddBtn[i * 2].Enabled = true;
                    NapomenutiRemBtn[i * 2].Enabled = true;
                    NapomenutiAddBtn[i * 2 + 1].Enabled = true;
                    NapomenutiRemBtn[i * 2 + 1].Enabled = true;
                    Jmeno[i * 2 + 1].BackColor = SystemColors.Control;
                    Pozadi[i * 2 + 1].BackColor = SystemColors.Control;
                    Jmeno[i * 2].BackColor = SystemColors.Control;
                    Pozadi[i * 2].BackColor = SystemColors.Control;
                }
            }
        }

        private char prevadec(int poradi)
        {
            switch (poradi)
            {
                case 0:
                    return '0';
                case 1:
                    return 'M';
                case 2:
                    return 'K';
                case 3:
                    return 'D';
                case 4:
                    return 'T';
                case 5:
                    return '=';
            }
            return '0';
        }

        private int prevadec(char poradi)
        {
            switch (poradi)
            {
                case '0':
                    return 0;
                case 'M':
                    return 1;
                case 'K':
                    return 2;
                case 'D':
                    return 3;
                case 'T':
                    return 4;
                case '=':
                    return 5;
            }
            return 0;
        }

    }
}
