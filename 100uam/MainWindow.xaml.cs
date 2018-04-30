﻿using System;
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
using System.Media;

using System.IO;
using _100uam.Views;
using _100uam.Elements;

namespace _100uam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        SoundPlayer mediaPlayer = new SoundPlayer(@"C:\Users\Anovac\Desktop\Hackathon\100uam\bensound-jazzyfrenchy.wav");

        public int gameyear = 1919;
        public int wydatki = 0;
        public int prestiz = 0;
        public int zadowolenie =0;
        public int wyplata;
        public Player player = new Player("Rektor UAM");
        List<Wydzialy> posiadane = new List<Wydzialy>();
        List<Wydzialy> otoczenie = new List<Wydzialy>();
        public MainWindow()
        {
            InitializeComponent();
            
            DescribePersonel.Text = "Zbuduj wydział aby zatrudniać pracowników. Ekipa sprzątająca podnosi zadowolenie studentów,\nnatomiast wykładowcy wpływają\n na prestiż uczelni.      \nUważaj!\nZbyt duża liczba pracowników może mocno obciążyć twój budżet a otoczeni przez wykładowców studenci nie będą zadowoleni!";
            playerName.Text = player.Name;
            Aktualizacja(); 
            bottomPanel.Visibility = System.Windows.Visibility.Hidden;
            showBottomPanel.Visibility = System.Windows.Visibility.Visible;
            otoczenie.Add(new Wydzialy("Anglistyka", "Wydział Anglistyki\n", 40000000, 10000));
            otoczenie.Add(new Wydzialy("Biologia", "Wydział Biologii\n", 20000000, 16000));
            otoczenie.Add(new Wydzialy("Chemia", "Wydział Chemii\n", 15000000, 12000));
            otoczenie.Add(new Wydzialy("WFPiK", "Wydział Filologii Polskiej i Klasycznej\n", 10000000, 60000));
            otoczenie.Add(new Wydzialy("Fizyka", "Wydział Fizyki\n", 40000000, 10000));
            otoczenie.Add(new Wydzialy("Historia", "Wydział Historyczny\n", 20000000, 50000));
            otoczenie.Add(new Wydzialy("WMI", "Wydział Matematyki i Informatyki\n", 30000000, 10000));
            otoczenie.Add(new Wydzialy("WNGiG", "Wydział Nauk Geograficznych i Geologicznych\n", 20000000, 16000));
            otoczenie.Add(new Wydzialy("WNPiD", "Wydział Nauk Politycznych i Dziennikarstwa\n", 21000000, 15000));
            otoczenie.Add(new Wydzialy("WNS", "Wydział Nauk Społecznych\n", 18000000, 16000));
            otoczenie.Add(new Wydzialy("Neofilologia", "Wydział Neofilologii\n", 25000000, 14000));
            otoczenie.Add(new Wydzialy("WPiA", "Wydział Prawa i Administracji\n", 20000000, 20000));
            otoczenie.Add(new Wydzialy("WSE", "Wydział Studiów Edukacyjnych\n", 10000000, 50000));
            otoczenie.Add(new Wydzialy("Teologia", "Wydział Teologiczny\n", 15000000,60000));
            SetMap();
            mediaPlayer.PlayLooping();
            MessageBox.Show("Zaczynasz jako jeden z założycieli UAM. Aby uzyskać pomoc kliknij w znak zapytania w prawym górnym rogu aplikacji!");
        }



        //Bottom Grin Button Logic
        private void ShowBottomPanelClick(object sender, RoutedEventArgs e)
        {
            bottomPanel.Visibility = System.Windows.Visibility.Visible;
            showBottomPanel.Visibility = System.Windows.Visibility.Hidden;
            staffButton.Visibility = System.Windows.Visibility.Visible;
            buildingsButton.Visibility = System.Windows.Visibility.Hidden;
            staffGrid.Visibility = System.Windows.Visibility.Hidden;
            buildingsGrid.Visibility = System.Windows.Visibility.Visible;
        }

        private void BottomCollapseClick(object sender, RoutedEventArgs e)
        {
            bottomPanel.Visibility = System.Windows.Visibility.Hidden;
            showBottomPanel.Visibility = System.Windows.Visibility.Visible;   
        }

        private void BuildingsButtonClick(object sender, RoutedEventArgs e)
        {
            buildingsButton.Visibility = System.Windows.Visibility.Hidden;
            staffButton.Visibility = System.Windows.Visibility.Visible;
            buildingsGrid.Visibility = System.Windows.Visibility.Visible;
            staffGrid.Visibility = System.Windows.Visibility.Hidden;
            Aktualizacja();
        }

        private void StaffButtonClick(object sender, RoutedEventArgs e)
        {
            buildingsButton.Visibility = System.Windows.Visibility.Visible;
            staffButton.Visibility = System.Windows.Visibility.Hidden;
            buildingsGrid.Visibility = System.Windows.Visibility.Hidden;
            staffGrid.Visibility = System.Windows.Visibility.Visible;
            Aktualizacja();
        }

        private void nextRound_Click(object sender, RoutedEventArgs e)
        {
            Aktualizacja();
            player.playermoney = player.playermoney - wydatki;
            foreach(Wydzialy wydzial in posiadane)
            {
                player.playermoney=player.playermoney-(wydzial.GetUtrzymanieD);
            }

            if(player.playermoney<0)
            {
                MessageBox.Show("Przegrałeś :(");
                System.Windows.Application.Current.Shutdown();
            }

            gameyear = gameyear + 1;
            wydatki = 0;
            Aktualizacja();

        }
 
        public void Aktualizacja()
        {
            Random rnd = new Random();
            Parser parser = new Parser();
            int studenci = 0;
            int pracownicy = 0;
            double prestiz=0;
            wyplata=0;
            double zadowolenie=0;
            posiadane.Clear();
            foreach (Wydzialy wydzial in otoczenie)
            {
                if (wydzial.Status == 1)
                    posiadane.Add(wydzial);
            }
            foreach (Wydzialy wydzialy in posiadane)
            {
                studenci = studenci + wydzialy.LiczbaStudentow;
                prestiz = prestiz + wydzialy.GetPrestiz;
                wyplata = wyplata + wydzialy.GetWyplata;
                zadowolenie = zadowolenie + wydzialy.GetZadowolenie;
                pracownicy = pracownicy + wydzialy.LiczbaPersonelu + wydzialy.LiczbaWykladowcow;

            }
            prestiz = prestiz / posiadane.Count;
            zadowolenie = zadowolenie / posiadane.Count;
            money.Text ="Kwota: " + parser.ParseNumber(player.Playermoney.ToString()) + " zł";
            round.Text = "Wydatki: " + parser.ParseNumber(wydatki.ToString()) + " zł";
            year.Text = "Rok "+ gameyear;
            if (studenci != 0)
                studentCount.Text = "Student Count: " + (studenci + +rnd.Next(1, 100));
            else
                studentCount.Text = "Student Count: " + (studenci);
            expenses.Text = "Przychód: " + parser.ParseNumber(wyplata.ToString()) +" zł";
            staffCount.Text = "Staff Count: " + pracownicy;
            satisfaction.Width = 174 * zadowolenie / 100;
            prestige.Width = 174 * prestiz / 100;
        }
        private void SetMap()
        {
            Random rnd = new Random();
            for (int i = 1; i < otoczenie.Count; i++)
            {
                int texture_number = rnd.Next(1, 4);
                emptyArea emptyArea = new emptyArea(otoczenie[i-1], @"C:\Users\Anovac\Desktop\100lecie\grafika\trees0" + texture_number.ToString() + @".png",this);
                StackPanel txt = FindName("area" + i) as StackPanel;
                txt.Children.Add(emptyArea);
            }
        }


        private void SetWydzial(emptyArea element)
        {

        }

        private void area1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel stackPanel = sender as StackPanel;
            Wydzialy wydzial = (stackPanel.Children[0] as emptyArea).GetOtoczenie;
            ViewWykladowca wykladowcatmp = new ViewWykladowca(wydzial, this);
            ViewPersonel personeltmp = new ViewPersonel(wydzial, this);
            PersonelStackPanel.Children.Clear();
            WydzialDescription.Text = wydzial.GetDescription;
            if (wydzial.Status == 1)
            {
                PersonelStackPanel.Children.Add(wykladowcatmp);
                PersonelStackPanel.Children.Add(personeltmp);
            }
            Aktualizacja();
        }

        private void nextRound_Click_1(object sender, RoutedEventArgs e)
        {
            player.playermoney = player.playermoney - wydatki +  wyplata;
            Aktualizacja();

            if (player.playermoney < 0)
            {
                MessageBox.Show("Przegrałeś :(");
                System.Windows.Application.Current.Shutdown();
            }

            else if (gameyear == 2019 && (otoczenie.Count -1) != posiadane.Count)
            {
                MessageBox.Show("Przegrałeś, nie masz wszystkich wydziałów :(");
                System.Windows.Application.Current.Shutdown();
            }
            else if (gameyear == 2019 && otoczenie.Count == posiadane.Count)
            {
                MessageBox.Show("Wygrałeś :DDDDD");
                System.Windows.Application.Current.Shutdown();
            }
            gameyear = gameyear + 1;

            wydatki = 0;
            Aktualizacja();
            foreach (Wydzialy wydzialy in posiadane)
            {
                wydatki = wydatki + (wydzialy.GetUtrzymanieD);
            }
            Aktualizacja();
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pamiętaj, że rachunki zostaną odjęte a zyski przyznane po zakończeniu rundy. Aby zatrudnić pracowików skorzystaj z rozsuwanego menu w lewym dolnym rogu ekranu!\nAutorzy: Magdalena Wilczyńska, Anna Nowak");
        }
    }
}
