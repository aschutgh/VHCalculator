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

namespace VHCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            int eg = int.Parse(tboxEersteGetal.Text);
            int tg = int.Parse(tboxTweedeGetal.Text);
            if (rdbOptellen.IsChecked == true) lblResultaat.Content = $"{eg} + {tg} = {eg + tg}";
            if (rdbAftrekken.IsChecked == true) lblResultaat.Content = $"{eg} - {tg} = {eg - tg}";
            if (rdbVermenigvuldigen.IsChecked == true) lblResultaat.Content = $"{eg} * {tg} = {eg * tg}";
            if (rdbDelen.IsChecked == true) lblResultaat.Content = $"{eg} / {tg} = {eg / tg}";
        }
    }
}
