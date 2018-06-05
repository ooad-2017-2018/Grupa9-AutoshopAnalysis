using System;

using App9.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App9.Views
{
    public sealed partial class PregledStatistikeDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(PregledStatistikeDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public PregledStatistikeDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as PregledStatistikeDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
