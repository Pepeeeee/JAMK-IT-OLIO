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

namespace LABRA10
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
            //lisätään compoboxiin itemeitä
            cbMagazines.Items.Add("Iltalehti");
            cbMagazines.Items.Add("V8 Magazine");
            cbMagazines.Items.Add("Aku Ankka");
            cbMagazines.Items.Add("UrheiluSanomat");
            cbMagazines.Items.Add("Jallu-Lehti");
            cbMagazines.Items.Add("");
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            //tutkitaan mitä kontrolleja (tuotteita) käyttäjä on valinnut
            string msg = "";
            //Vaihtoehto1 kontrolli kerrallaan -->   JÄLKEENPÄIN KIRJOITETTU -->    näinkin voi tehdä mutta on parempikin keino - -- - -- - -- - --
           /* if ((bool)chkBanana.IsChecked)
            {
                msg += "Banaaneja 1 kg \n";
            }

            //ostokset näkyviin
            txtList.Text = msg;

            if ((bool)chkBread.IsChecked)
            {
                msg += "Leipää 1 paketti \n";
            }
            //ostokset näkyviin 
            txtList.Text = msg; */

            // vaihtoehto 2! :) käydään kaikki kontrollit loopissa läpi.
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
            //tutkitaan onko comboboxista valittu jokin lehti?
            if (cbMagazines.SelectedIndex > 0)
                msg += cbMagazines.SelectedValue;
            else msg += "ei vilkuilla lehtiä";




            //ostokset näkyviin 
            txtList.Text = msg;


        } // <---------

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            //kutsutaan näkyviin about ikkuna
            About win = new About();
            win.Show();
            //win.ShowDialog();
        }
    }
    }

