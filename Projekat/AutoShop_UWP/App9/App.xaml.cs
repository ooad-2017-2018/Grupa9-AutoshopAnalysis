﻿using System;

using App9.Services;

using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Microsoft.WindowsAzure.MobileServices;

namespace App9
{
    public sealed partial class App : Application
    {

        public static MobileServiceClient MobileService = new MobileServiceClient("https://AutoshopAnalysis.azurewebsites.net");
        private Lazy<ActivationService> _activationService;

        private ActivationService ActivationService
        {
            get { return _activationService.Value; }
        }

        public App()
        {
            InitializeComponent();

            // Deferred execution until used. Check https://msdn.microsoft.com/library/dd642331(v=vs.110).aspx for further info on Lazy<T> class.
            _activationService = new Lazy<ActivationService>(CreateActivationService);
        }

        protected override async void OnLaunched(LaunchActivatedEventArgs args)
        {
            if (!args.PrelaunchActivated)
            {
                await ActivationService.ActivateAsync(args);
            }
        }

        protected override async void OnActivated(IActivatedEventArgs args)
        {
            await ActivationService.ActivateAsync(args);
        }

        private ActivationService CreateActivationService()
        {
            return new ActivationService(this, typeof(Views.LoginPage));
        }
    }
}
