﻿using System.Windows;
using EDEngineer.Models.Localization;

namespace EDEngineer
{
    /// <summary>
    /// Interaction logic for SelectLanguageWindow.xaml
    /// </summary>
    public partial class SelectLanguageWindow
    {
        public SelectLanguageWindow(Languages languages)
        {
            InitializeComponent();
            DataContext = languages;
        }

        private void OkButtonClicked(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
