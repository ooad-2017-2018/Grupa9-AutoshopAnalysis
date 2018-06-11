using App9.Model;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace App9.Views
{
    public sealed partial class RegistracijaPage : Page, INotifyPropertyChanged
    {
        IMobileServiceTable<Korisnik> userTableObj = App.MobileService.GetTable<Korisnik>();
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
            try
            {
                Korisnik obj = new Korisnik();
                obj.ime = ImeTekst.Text;
                obj.prezime = PrezimeTekst.Text;
                obj.email = EmailTekst.Text;
                obj.username = KorisnickoIme.Text;
                obj.password = SifraTekst.Password;
                App.korisniks.Add(obj);
                await userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog studenta.");

                await msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " +
               ex.ToString());
                await msgDialogError.ShowAsync();
            }
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
