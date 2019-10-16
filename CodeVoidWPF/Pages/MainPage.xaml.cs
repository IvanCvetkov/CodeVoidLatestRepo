using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Reflection;
using System.IO;
using System;
using System.Windows.Documents;

namespace CodeVoidWPF.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/MainPages/About/About.xaml", UriKind.Relative));
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Location_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/MainPages/Location/Location.xaml", UriKind.Relative));
        }

    }
}
