using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

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

        public void vykreslitGrid()
        {
            zapasniciSeznam.Rows.Clear();


            for (int i = 0; i < _parent.zapasnici.Count; i++)
            {
                if(_parent.zapasnici[i].uroven <= urovenHorniHranice && _parent.zapasnici[i].uroven >= urovenSpodniHranice && _parent.zapasnici[i].vek >= vekDolniHranice && _parent.zapasnici[i].vek <= vekHorniHranice) { 
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(zapasniciSeznam);
                    row.Cells[0].Value = _parent.zapasnici[i].ID;
                    row.Cells[1].Value = _parent.zapasnici[i].jmeno;
                    row.Cells[2].Value = _parent.zapasnici[i].prijmeni;
                    row.Cells[3].Value = _parent.zapasnici[i].vek;
                    row.Cells[4].Value = cisloNaUroven(_parent.zapasnici[i].uroven);
                    row.Cells[5].Value = _parent.zapasnici[i].ucastnikTurnaje;
                    if(_parent.zapasnici[i].ucastnikTurnaje == 1) { 
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                        row.DefaultCellStyle.Font = new Font(zapasniciSeznam.RowTemplate.DefaultCellStyle.Font, FontStyle.Bold);
                    }
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

        private void vytvoritZapasnika_Click(object sender, EventArgs e)
        {
            _parent.Zobrazovac("EditovatZapasnika");
            EditovatZapasnika.Instance.nastavitLabel("Vytvořit zápasníka");
            EditovatZapasnika.Instance.clear();
        }

        private void editovatZapasnika_Click(object sender, EventArgs e)
        {
            if(zapasniciSeznam.SelectedRows.Count == 1) { 
            _parent.Zobrazovac("EditovatZapasnika");
            EditovatZapasnika.Instance.nastavitLabel("Editovat zápasníka");
            EditovatZapasnika.Instance.nastavitHodnoty(Convert.ToInt32(zapasniciSeznam.SelectedRows[0].Cells[0].Value));
            }
            else
            {
                MessageBox.Show("Pro editaci zápasníka musí být vybrán řádek se zápasníkem", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void smazatZapasnika_Click(object sender, EventArgs e)
        {
            if (zapasniciSeznam.SelectedRows.Count == 1)
            {
                for (int i = 0; i < _parent.zapasnici.Count; i++)
                {
                    if (_parent.zapasnici[i].ID == Convert.ToByte(zapasniciSeznam.SelectedRows[0].Cells[0].Value))
                    {
                        DialogResult dialogResult = MessageBox.Show("Opravdu vymazat zápasníka "+_parent.zapasnici[i].jmeno+" " + _parent.zapasnici[i].prijmeni+ "?" , "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            _parent.zapasnici.RemoveAt(i);
                            _parent.UlozitZapasniky();
                            vykreslitGrid();
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Pro vymazání zápasníka musí být vybrán řádek se zápasníkem", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resetovatFiltry_Click(object sender, EventArgs e)
        {
            nastavVychozi();
        }

        private void pridatDoTurnaje_Click(object sender, EventArgs e)
        {
            if (zapasniciSeznam.SelectedRows.Count == 1)
            {
                for (int i = 0; i < _parent.zapasnici.Count; i++)
                {
                    if (_parent.zapasnici[i].ID == Convert.ToByte(zapasniciSeznam.SelectedRows[0].Cells[0].Value))
                    {
                            _parent.zapasnici[i].ucastnikTurnaje = 1 ;
                            vykreslitGrid();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Pro přidání zápasníka do turnaje musí být vybrán řádek se zápasníkem", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void odebratZTurnaje_Click(object sender, EventArgs e)
        {
            if (zapasniciSeznam.SelectedRows.Count == 1)
            {
                for (int i = 0; i < _parent.zapasnici.Count; i++)
                {
                    if (_parent.zapasnici[i].ID == Convert.ToByte(zapasniciSeznam.SelectedRows[0].Cells[0].Value))
                    {
                        _parent.zapasnici[i].ucastnikTurnaje = 0;
                        vykreslitGrid();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Pro odebrání zápasníka z turnaje musí být vybrán řádek se zápasníkem", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
