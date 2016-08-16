﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using myfoodapp.Model;
using myfoodapp.ViewModel;
using myfoodapp.Business;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace myfoodapp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.ViewModel = new AquaponicsManagementViewModel();
            this.Loaded += MainPage_Loaded;
            this.InitializeComponent();
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = ViewModel;

            var mesureBackgroundTask = MeasureBackgroundTask.GetInstance;
            mesureBackgroundTask.Run();
        }

        public AquaponicsManagementViewModel ViewModel { get; set; }
    }
}
