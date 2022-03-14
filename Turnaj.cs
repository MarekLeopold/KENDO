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

        public void vykresli(Graphics g)
        {
            String text = "test";
            Font font = new Font("Arial", 12);
            SolidBrush barva = new SolidBrush(Color.Black);
            Pen CernePero = new Pen(Color.Black, 3);

            SizeF velikost = g.MeasureString(text, font);

            g.DrawString(text, font, barva, 10, 10);
            g.DrawRectangle(CernePero, 8, 8, velikost.Width+2, velikost.Height+2);
        }


        private void Grafika_Paint(object sender, PaintEventArgs e)
        {
            vykresli(e.Graphics);
        }
    }
}
