﻿#pragma checksum "C:\Users\Дмитрий\Desktop\Читай 2\FBReader.App\Views\Controls\MarginGridControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "38EE302609124BC4531D83F23AB303FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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

