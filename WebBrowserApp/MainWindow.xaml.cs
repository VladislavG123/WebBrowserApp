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

namespace WebBrowserApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string googleUrl;
        public MainWindow()
        {
            googleUrl = "https://www.google.com";
            InitializeComponent();
        }


        private void PulseTabItemPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs mouseEvent)
        {
            mainTabControl.Items.Insert(mainTabControl.Items.Count - 1, new TabItem() { Content = new WebBrowser() { Source = new Uri(googleUrl) }, Width = 50 });
            mainTabControl.SelectedItem = mainTabControl.Items[mainTabControl.Items.Count - 1];
        }
    }
}
