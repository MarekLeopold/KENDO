using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using System.Xml.Serialization;

namespace KENDO
{
    
    public partial class Form1 : Form
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/KENDO/"; // Cesta do pracovního adresáře
        List<Zapasnik> zapasnici = new List<Zapasnik>();

        public Form1()
        {
            InitializeComponent();
            Uloziste();
            NacistZapasniky();
            //UlozitZapasniky();
        }


        /* Vytvoření základní cesty k ukládání do XML */
        public void Uloziste()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(path + "Zapasnici.xml"))
            {
                UlozitZapasniky();
            }
        } 

        public void UlozitZapasniky()
        {
            XmlSerializer serializaceDat = new XmlSerializer(zapasnici.GetType());
            using (StreamWriter sw = new StreamWriter(path + "Zapasnici.xml"))
            {
                serializaceDat.Serialize(sw,zapasnici);
            }
        }

        private void NacistZapasniky()
        {
            try
            {
                if (File.Exists(path + "Zapasnici.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(zapasnici.GetType());
                    using (StreamReader sr = new StreamReader(path + "Zapasnici.xml"))
                    {
                        zapasnici = (List<Zapasnik>)serializer.Deserialize(sr);
                    }
                }
                else throw new FileNotFoundException("Soubor nebyl nalezen");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /* Zobrazovací logika */
        public void Zobrazovac(String zobrazeni)
        {
            switch (zobrazeni)
            {
                case "EditovatZapasnika":
                    if (!display.Contains(EditovatZapasnika.Instance))
                    {
                        display.Controls.Add(EditovatZapasnika.Instance);
                        EditovatZapasnika.Instance.Dock = DockStyle.Fill;
                        EditovatZapasnika.Instance.BringToFront();
                        EditovatZapasnika.Instance.setParent(this);
                    }
                    else
                    {
                        EditovatZapasnika.Instance.BringToFront();
                    }

                    EditovatZapasnika.Instance.setFocus();
                    break;

                default:
                    break;
            }

        }
    }
}
