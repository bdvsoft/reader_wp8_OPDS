﻿#pragma checksum "C:\Читай 2\FBReader.App\Views\Pages\ReadPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "162292105C43F86C3C87483A7BEFC547"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.36279
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FBReader.App.Controls;
using FBReader.App.Controls.ApplicationBar;
using FBReader.App.Views.Controls;
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


namespace FBReader.App.Views.Pages {
    
    
    public partial class ReadPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage Page;
        
        internal System.Windows.Controls.Canvas LayoutRoot;
        
        internal FBReader.App.Controls.ThreePagePanel PageCanvas;
        
        internal FBReader.App.Views.Controls.ColorSelectorControl ColorSelector;
        
        internal FBReader.App.Controls.TranslationControl TranslationControl;
        
        internal FBReader.App.Controls.ApplicationBar.FBReaderApplicationBar AppBar;
        
        internal System.Windows.Controls.Canvas Brightness;
        
        internal Telerik.Windows.Controls.RadListPicker ShareMethodPicker;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FBReader.App;component/Views/Pages/ReadPage.xaml", System.UriKind.Relative));
            this.Page = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("Page")));
            this.LayoutRoot = ((System.Windows.Controls.Canvas)(this.FindName("LayoutRoot")));
            this.PageCanvas = ((FBReader.App.Controls.ThreePagePanel)(this.FindName("PageCanvas")));
            this.ColorSelector = ((FBReader.App.Views.Controls.ColorSelectorControl)(this.FindName("ColorSelector")));
            this.TranslationControl = ((FBReader.App.Controls.TranslationControl)(this.FindName("TranslationControl")));
            this.AppBar = ((FBReader.App.Controls.ApplicationBar.FBReaderApplicationBar)(this.FindName("AppBar")));
            this.Brightness = ((System.Windows.Controls.Canvas)(this.FindName("Brightness")));
            this.ShareMethodPicker = ((Telerik.Windows.Controls.RadListPicker)(this.FindName("ShareMethodPicker")));
        }
    }
}

