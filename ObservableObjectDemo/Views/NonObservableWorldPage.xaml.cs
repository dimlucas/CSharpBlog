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
using ObservableObjectDemo.ViewModels;
using Windows.UI.Core;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ObservableObjectDemo.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NonObservableWorldPage : Page
    {
        public NonObservableWorldPage()
        {
            this.InitializeComponent();
            ViewModel = new NonObservableWorldViewModel();
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += (sender, args) =>
            {
                if (Frame.CanGoBack)
                {
                    Frame.GoBack();
                    args.Handled = true;
                }
            };
        }

        public NonObservableWorldViewModel ViewModel { get; private set; }

    }
}
