using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using App9.Models;
using App9.Services;

using Windows.UI.Xaml.Controls;

namespace App9.Views
{
    public sealed partial class Chart3Page : Page, INotifyPropertyChanged
    {
        // TODO WTS: Change the chart as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/radchart/getting-started
        public Chart3Page()
        {
            InitializeComponent();
            DataContext = this;
            mychart.Series[0].ItemsSource = CreateData();
        }

        public List<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return FakeBaza.GetChart1SampleData();
            }
        }
        public class Data
        {
            public double Value { get; set; }
        }

        public List<Data> CreateData()
        {
            List<Data> data = new List<Data>();
            data.Add(new Data() { Value = 20 });
            data.Add(new Data() { Value = 45 });
            data.Add(new Data() { Value = 35 });

            return data;
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
    }
}
