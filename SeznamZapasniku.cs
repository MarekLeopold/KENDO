using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;


namespace KENDO
{
    public partial class SeznamZapasniku : UserControl
    {
        private static SeznamZapasniku _instance;
        private Form1 _parent = null;
        private byte urovenSpodniHranice;
        private byte urovenHorniHranice;
        private byte vekDolniHranice;
        private byte vekHorniHranice;


        public static SeznamZapasniku Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SeznamZapasniku();
                return _instance;
            }
        }
        public void setFocus()
        {
           // jmeno.Focus();
        }

        public void setParent(Form1 uk)
        {
            _parent = uk;
        }

        public SeznamZapasniku()
        {
            InitializeComponent();
            
        }

        public void nastavVychozi()
        {

            
            urovenSpodniHranice = 0;
            urovenHorniHranice = 19;
            vekDolniHranice = 0;
            vekHorniHranice = 254;

            omezeniStupneOd.SelectedIndex = urovenSpodniHranice;
            omezeniStupneDo.SelectedIndex = urovenHorniHranice;

            omezeniVekuOd.Text = Convert.ToString(vekDolniHranice);
            omezeniVekuDo.Text = Convert.ToString(vekHorniHranice);

            vykreslitGrid();
        }

        private void vykreslitGrid()
        {
            zapasniciSeznam.Rows.Clear();


            for (int i = 0; i < _parent.zapasnici.Count; i++)
            {
                if(_parent.zapasnici[i].uroven <= urovenHorniHranice && _parent.zapasnici[i].uroven >= urovenSpodniHranice && _parent.zapasnici[i].vek >= vekDolniHranice && _parent.zapasnici[i].vek <= vekHorniHranice) { 
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(zapasniciSeznam);

                    row.Cells[0].Value = _parent.zapasnici[i].jmeno;
                    row.Cells[1].Value = _parent.zapasnici[i].prijmeni;
                    row.Cells[2].Value = _parent.zapasnici[i].vek;
                    row.Cells[3].Value = cisloNaUroven(_parent.zapasnici[i].uroven);
                    zapasniciSeznam.Rows.Add(row);
                }
            }
        }

        private void omezeniVekuOd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void omezeniVekuDo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string cisloNaUroven(byte cislo)
        {
            switch (cislo)
            {
                case 0: return "10 kjú";
                case 1: return "9 kjú";
                case 2: return "8 kjú";
                case 3: return "7 kjú";
                case 4: return "6 kjú";
                case 5: return "5 kjú";
                case 6: return "4 kjú";
                case 7: return "3 kjú";
                case 8: return "2 kjú";
                case 9: return "1 kjú";
                case 10: return "1 dan";
                case 11: return "2 dan";
                case 12: return "3 dan";
                case 13: return "4 dan";
                case 14: return "5 dan";
                case 15: return "6 dan";
                case 16: return "7 dan";
                case 17: return "8 dan";
                case 18: return "9 dan";
                case 19: return "10 dan";
                default: return "error";
            }
            return "error";
        }

        private void omezeniStupneOd_SelectedIndexChanged(object sender, EventArgs e)
        {
            urovenSpodniHranice = Convert.ToByte(omezeniStupneOd.SelectedIndex);
            vykreslitGrid();


        }

        private void omezeniStupneDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            urovenHorniHranice = Convert.ToByte(omezeniStupneDo.SelectedIndex);
            vykreslitGrid();
        }

        private void omezeniVekuOd_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(omezeniVekuOd.Text) > 254)
            {
                MessageBox.Show("Nejvyšší povolená hodnota věku je 254", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                vekDolniHranice = 254;
                omezeniVekuOd.Text = "254";
            }
            else
            {
                vekDolniHranice = Convert.ToByte(omezeniVekuOd.Text);
            }
            vykreslitGrid();
        }

        private void omezeniVekuDo_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(omezeniVekuDo.Text) > 254)
            {
                MessageBox.Show("Nejvyšší povolená hodnota věku je 254", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                vekHorniHranice = 254;
                omezeniVekuDo.Text = "254";
            }
            else
            {
                vekHorniHranice = Convert.ToByte(omezeniVekuDo.Text);
            }
            vykreslitGrid();
        }
    }
}
