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

namespace Calculator
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
        private void SevetBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            MessageBox.Show(name);
        }

        private void EightBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NineBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FourBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
