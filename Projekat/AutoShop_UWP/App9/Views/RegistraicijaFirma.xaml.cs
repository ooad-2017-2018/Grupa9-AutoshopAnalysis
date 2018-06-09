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

        private async void RegistracijaButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Uspješna registracija!");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "OK", Id = 0 });
            await msgbox.ShowAsync();
            Frame.Navigate(typeof(LoginPage));
        }
    }
}
