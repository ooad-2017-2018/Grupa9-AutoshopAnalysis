﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace App9.Views
{
    public sealed partial class LoginPage : Page, INotifyPropertyChanged
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        

        private void HyperlinkButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegistracijaPage));
        }

        private async void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if(KorImeTekst.Text == "Admin" && SifraTekst.Text == "Admin")
            {
                this.Frame.Navigate(typeof(UserHomePagePage));
            }
            else
            {
                MessageDialog msgbox = new MessageDialog("Unesi Admim, Admin");
                msgbox.Commands.Clear();
                msgbox.Commands.Add(new UICommand { Label = "OK", Id = 0 });
                await msgbox.ShowAsync();
            }
        }
        
    }
}