using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App9.Views
{
    public sealed partial class RegistracijaPage : Page, INotifyPropertyChanged
    {
        public RegistracijaPage()
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


        private async void RegistracijaButtonDugme_ClickAsync(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Uspješna registracija korisnika!");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "OK", Id = 0 });
            await msgbox.ShowAsync();
            Frame.Navigate(typeof(LoginPage));
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
