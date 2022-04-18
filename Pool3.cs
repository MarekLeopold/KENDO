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


        private void vykresli()
        {
          
        }

    }
}
