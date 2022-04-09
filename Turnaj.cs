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
    public partial class Turnaj : UserControl
    {
        private static Turnaj _instance;
        private Form1 _parent = null;

        public static Turnaj Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Turnaj();
                return _instance;
            }
        }

        public void setParent(Form1 uk)
        {
            _parent = uk;
        }

        public Turnaj()
        {
            InitializeComponent();
        }

        private void Grafika_Paint(object sender, PaintEventArgs e)
        {
            int maximalniSirka = 0;
            for (int i = 0; i < _parent.pooly.Count; i++)
            {
                int test = Convert.ToInt32(_parent.pooly[i].size(e.Graphics).Width);
                if (maximalniSirka < test)
                {
                    maximalniSirka = test;
                }

                if(_parent.pooly[i].vysledek(0) != -1) 
                {
                    _parent.finalniDvojice[i].add(_parent.pooly[i].zapasnici[_parent.pooly[i].vysledek(0)].jmeno + " " + _parent.pooly[i].zapasnici[_parent.pooly[i].vysledek(0)].prijmeni, 0);
                }
                if (_parent.pooly[_parent.pooly.Count-1-i].vysledek(1) != -1)
                {
                     _parent.finalniDvojice[_parent.pooly.Count - 1 - i].add(_parent.pooly[_parent.pooly.Count - 1 - i].zapasnici[_parent.pooly[_parent.pooly.Count - 1 - i].vysledek(0)].jmeno + " " + _parent.pooly[_parent.pooly.Count - 1 - i].zapasnici[_parent.pooly[_parent.pooly.Count - 1 - i].vysledek(0)].prijmeni, 0);
                }
            }


            int posun = 10;
            for (int i = _parent.pooly.Count - 1; i >= 0; i--)
            {
                _parent.pooly[i].nastavSirku(maximalniSirka);
                _parent.pooly[i].vykresli(e.Graphics, 5, posun, _parent.pooly.Count - i);
                posun = posun + Convert.ToInt32(_parent.pooly[i].size(e.Graphics).Height) + 5;
            }

            posun = 10;
            _parent.finalniDvojice[0].nastavSirku(maximalniSirka);
            _parent.finalniDvojice[0].vykresliCleny(e.Graphics, maximalniSirka + 25, posun);





        }

        private void Grafika_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point souradnice = me.Location;
            for (int i = 0; i < _parent.pooly.Count; i++)
            {
                if (_parent.pooly[i].kliknutoV(souradnice))
                {
                    if (_parent.pooly[i].pocetZapasniku() == 3)
                    {
                        _parent.Zobrazovac("Pool3");
                        Pool3.Instance.set(_parent.pooly.Count - i);
                    }
                    break;
                }
            }


        }
    }
}
