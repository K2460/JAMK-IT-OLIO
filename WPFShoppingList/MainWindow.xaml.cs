using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFShoppingList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeMyStuff();
        }
        private void InitializeMyStuff()
        {
            //kootaan tähän metodiin kaikki kontrollien alustukset
            //lisätään comboboxiin itemeita/tavaraa
            cbMagazines.Items.Add("");
            cbMagazines.Items.Add("Iltalehti");
            cbMagazines.Items.Add("V8 Magazine");
            cbMagazines.Items.Add("Aku Ankka");
            cbMagazines.Items.Add("Urheilusanomat");
        }
        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            //tutkitaan mitä kontrolleja käyttäjä valinnut
            string msg = "";
            //kontrolli kerrallaan
            if ((bool)chkBanana.IsChecked)
            {
                msg += "banaaneja 1 kg \n";
            }
            if ((bool)chkBread.IsChecked)
            {
                msg += "ruisleipää reissumies 1 kpl \n";
            }
            if ((bool)chkChicken.IsChecked)
            {
                msg += "broileria \n";
            }
            if ((bool)chkSausage.IsChecked)
            {
                msg += "makkaraa \n";
            }
            if ((bool)chkBeer.IsChecked)
            {
                msg += "olutta \n";
            }
            //VE2: käydään kaikki kontrollit loopissa läpi
            foreach (object control in spList.Children)
            {
                if (control is CheckBox)
                {
                    CheckBox cb = (CheckBox)control;
                    if ((bool)cb.IsChecked)
                    {
                        msg += cb.Content + "\n";
                    }
                }
            }
            //tutkitaan onko comboboxista valittu jokin lehti
            if (cbMagazines.SelectedIndex >= 0)
                msg += cbMagazines.SelectedValue;
            else
                msg += "ei vilkuilla lehtihyllyä";
            //ostokset näkyviin
            txtList.Text = msg;
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            //kutsutaan näkyviin About-ikkuna
            About win = new About();
            //kaksi eri metodia näyttää uusi ikkuna: modaalinen ja ei-modaalinen
            //win.Show();
            win.ShowDialog();
        }
    }
}
