﻿using myfoodapp.Common;
using myfoodapp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace myfoodapp.ViewModel
{
    public class SettingsViewModel : BindableBase
    {
        public SettingsViewModel()
        {
        }

        public void OnPHSensorSettingsClicked(object sender, RoutedEventArgs args)
        {
            App.TryShowNewWindow<PhCalibrationPage>();
        }

        public void OnTempSensorSettingsClicked(object sender, RoutedEventArgs args)
        {
            App.TryShowNewWindow<PhCalibrationPage>();
        }

        public void OnORPSensorSettingsClicked(object sender, RoutedEventArgs args)
        {
            App.TryShowNewWindow<PhCalibrationPage>();
        }

        public void OnDOSensorSettingsClicked(object sender, RoutedEventArgs args)
        {
            App.TryShowNewWindow<PhCalibrationPage>();
        }

        public void OnClockSettingsClicked(object sender, RoutedEventArgs args)
        {
            App.TryShowNewWindow<ClockManagementPage>();
        }

        public void OnLogManagementClicked(object sender, RoutedEventArgs args)
        {
            App.TryShowNewWindow<LogManagementPage>();
        }
        
        public void OnAdvancedSettingsClicked(object sender, RoutedEventArgs args)
        {
            App.TryShowNewWindow<AdvancedSettingsPage>();
        }
        public void OnAboutClicked(object sender, RoutedEventArgs args)
        {
            App.TryShowNewWindow<AboutPage>();
        }
    }
}
