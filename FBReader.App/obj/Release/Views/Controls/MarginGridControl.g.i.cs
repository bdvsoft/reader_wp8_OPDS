﻿#pragma checksum "E:\Dev\Mobile\FBReader\src\FBReader.App\Views\Controls\MarginGridControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2527CD050D443FF07862299611913E59"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace FBReader.App.Views.Controls {
    
    
    public partial class MarginGridControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.UserControl self;
        
        internal System.Windows.Shapes.Line LeftLine;
        
        internal System.Windows.Shapes.Line RightLine;
        
        internal System.Windows.Shapes.Line TopLine;
        
        internal System.Windows.Shapes.Line BottomLine;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FBReader.App;component/Views/Controls/MarginGridControl.xaml", System.UriKind.Relative));
            this.self = ((System.Windows.Controls.UserControl)(this.FindName("self")));
            this.LeftLine = ((System.Windows.Shapes.Line)(this.FindName("LeftLine")));
            this.RightLine = ((System.Windows.Shapes.Line)(this.FindName("RightLine")));
            this.TopLine = ((System.Windows.Shapes.Line)(this.FindName("TopLine")));
            this.BottomLine = ((System.Windows.Shapes.Line)(this.FindName("BottomLine")));
        }
    }
}
