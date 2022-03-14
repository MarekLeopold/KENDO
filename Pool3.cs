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
        }

        private void navratKZapasu_Click(object sender, EventArgs e)
        {
            _parent.Zobrazovac("Turnaj");
        }

        public void set(int poolNo)
        {
            infoPopisek.Text = "POOL " + Convert.ToString(poolNo);
        }
    }
}
