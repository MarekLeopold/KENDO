using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KENDO
{
    public partial class EditovatZapasnika : UserControl
    {

        private static EditovatZapasnika _instance;
        private Form1 _parent = null;

        int ID;

        public static EditovatZapasnika Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EditovatZapasnika();
                return _instance;
            }
        }
        public void setFocus()
        {
            jmeno.Focus();
        }

        public void setParent(Form1 uk)
        {
            _parent = uk;
        }

        public EditovatZapasnika()
        {
            InitializeComponent();
            uroven.SelectedIndex = 0;
            ID = 0;
        }

        private void vek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ulozit_Click(object sender, System.EventArgs e)
        {
            if(jmeno.Text == "")
            {
                MessageBox.Show("Jméno nemůže zůstat prázdné !", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
            }
            else if(prijmeni.Text == "")
            {
                MessageBox.Show("Příjmení nemůže zůstat prázdné !", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (vek.Text == "")
            {
                MessageBox.Show("Věk nemůže zůstat prázdný !", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt32(vek.Text) > 255)
            {
                MessageBox.Show("Tak dlouho člověk nežije !", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(ID == 0) { 
                int newID = 1;
                if(_parent.zapasnici.Count > 0)
                {
                    newID = _parent.zapasnici.Last().ID + 1;
                }
                _parent.zapasnici.Add(new Zapasnik(newID, jmeno.Text, prijmeni.Text, Convert.ToByte(vek.Text), Convert.ToByte(uroven.SelectedIndex)));
                _parent.UlozitZapasniky();

                jmeno.Text = "";
                prijmeni.Text = "";
                vek.Text = "";
                uroven.SelectedIndex = 0;


                _parent.Zobrazovac("SeznamZapasniku");
                SeznamZapasniku.Instance.vykreslitGrid();
                MessageBox.Show("Zápasník uložen", "Potvrzení", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    for (int i = 0; i < _parent.zapasnici.Count; i++)
                    {
                        if (_parent.zapasnici[i].ID == ID)
                        {
                            _parent.zapasnici[i].jmeno = jmeno.Text;
                            _parent.zapasnici[i].prijmeni = prijmeni.Text;
                            _parent.zapasnici[i].vek = Convert.ToByte(vek.Text);
                            _parent.zapasnici[i].uroven = Convert.ToByte(uroven.SelectedIndex);
                            break;
                        }
                    }
                    _parent.UlozitZapasniky();
                    _parent.Zobrazovac("SeznamZapasniku");
                    SeznamZapasniku.Instance.vykreslitGrid();
                    MessageBox.Show("Zápasník uložen", "Potvrzení", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        public void clear()
        {
            jmeno.Text = "";
            prijmeni.Text = "";
            vek.Text = "";
            uroven.SelectedIndex = 0;
            ID = 0;
        }

        public void nastavitLabel(string hodnota)
        {
            infoLabel1.Text = hodnota;
        }

        public void nastavitHodnoty(int ID)
        {
            for(int i = 0; i < _parent.zapasnici.Count; i++)
            {
                if(_parent.zapasnici[i].ID == ID)
                {
                    this.ID = ID;
                    jmeno.Text = _parent.zapasnici[i].jmeno;
                    prijmeni.Text = _parent.zapasnici[i].prijmeni;
                    vek.Text = Convert.ToString(_parent.zapasnici[i].vek);
                    uroven.SelectedIndex = _parent.zapasnici[i].uroven;
                    break;
                }
            }
        }

        private void Stornovat_Click(object sender, EventArgs e)
        {
            clear();
            _parent.Zobrazovac("SeznamZapasniku");
            SeznamZapasniku.Instance.vykreslitGrid();
        }
    }
}
