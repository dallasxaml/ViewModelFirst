﻿using System.Windows;
using ViewModelFirst.Models;

namespace ViewModelFirst
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new NavigationProvider(new Context());
        }
    }
}
