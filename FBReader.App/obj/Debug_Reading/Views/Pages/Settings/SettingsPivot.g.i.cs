﻿#pragma checksum "E:\Dev\Mobile\FBReader\src\FBReader.App\Views\Pages\Settings\SettingsPivot.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D8A99CA06D89CA8F0509B70507422831"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cimbalino.Phone.Toolkit.Behaviors;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace FBReader.App.Views.Pages.Settings {
    
    
    public partial class SettingsPivot : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage self;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Cimbalino.Phone.Toolkit.Behaviors.ApplicationBarBehavior AppBar;
        
        internal Microsoft.Phone.Controls.Pivot Items;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/FBReader.App;component/Views/Pages/Settings/SettingsPivot.xaml", System.UriKind.Relative));
            this.self = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("self")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.AppBar = ((Cimbalino.Phone.Toolkit.Behaviors.ApplicationBarBehavior)(this.FindName("AppBar")));
            this.Items = ((Microsoft.Phone.Controls.Pivot)(this.FindName("Items")));
        }
    }
}

