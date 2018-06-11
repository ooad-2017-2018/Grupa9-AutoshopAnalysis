using App9.Model;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App9.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistraicijaFirma : Page
    {
        public RegistraicijaFirma()
        {
            this.InitializeComponent();
        }


        IMobileServiceTable<Autosalon> userTableObj = App.MobileService.GetTable<Autosalon>();
        
        private async void RegistracijaButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            try
            {
                Autosalon obj = new Autosalon();
                obj.ime = ImeTekst.Text;
                obj.idBroj = PrezimeTekst.Text;
                obj.email = EmailTekst.Text;
                obj.username = KorisnickoIme.Text;
                obj.password = SifraTekst.Password;
                App.autosalons.Add(obj);
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
    }
}
