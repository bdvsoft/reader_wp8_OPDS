﻿#pragma checksum "C:\Читай 2\FBReader.App\Views\Pages\Catalogs\CatalogPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0DE704663A53D7C5AD7810390D802C00"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.36279
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Telerik.Windows.Controls;


namespace FBReader.App.Views.Pages.Catalogs {
    
    
    public partial class CatalogPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Cimbalino.Phone.Toolkit.Behaviors.ApplicationBarBehavior AppBar;
        
        internal Telerik.Windows.Controls.RadDataBoundListBox ItemsControl;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FBReader.App;component/Views/Pages/Catalogs/CatalogPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.AppBar = ((Cimbalino.Phone.Toolkit.Behaviors.ApplicationBarBehavior)(this.FindName("AppBar")));
            this.ItemsControl = ((Telerik.Windows.Controls.RadDataBoundListBox)(this.FindName("ItemsControl")));
        }
    }
}

