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


        public Hodnoceni()
        {
            InitializeComponent();
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
            // 0 - 1  // 1 - 2
            // 1 - 2  // 3 - 4
            // 2 - 0  // 5 - 6
            int tentoHrac = 0;
            int vsHrac = 0;

            if (hrac == 1 || hrac == 6) { tentoHrac = 0; }
            else if (hrac == 2 || hrac == 3) { tentoHrac = 1; }
            else if (hrac == 4 || hrac == 5) { tentoHrac = 2; }

            if(hrac == 2 || hrac == 5) { vsHrac = 0; }
            else if (hrac == 1 || hrac == 4) { vsHrac = 1; }
            else if (hrac == 3 || hrac == 6) { vsHrac = 2; }


            popisekHodnoceni.Text = "Hodnocení hráče "+_parent.pooly[ID].zapasnici[tentoHrac].jmeno+" "+ _parent.pooly[ID].zapasnici[tentoHrac].prijmeni;
            popisekSouboj.Text = "V turnaji " + _parent.pooly[ID].zapasnici[tentoHrac].jmeno + " " + _parent.pooly[ID].zapasnici[tentoHrac].prijmeni + " vs " + _parent.pooly[ID].zapasnici[vsHrac].jmeno + " " + _parent.pooly[ID].zapasnici[vsHrac].prijmeni;
        }

        private void zpet_Click(object sender, EventArgs e)
        {
            _parent.Zobrazovac("Pool3");
        }
    }
}
