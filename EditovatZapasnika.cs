using System.Windows.Forms;

namespace KENDO
{
    public partial class EditovatZapasnika : UserControl
    {

        private static EditovatZapasnika _instance;
        private Form1 _parent = null;

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
        }

        private void vek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
