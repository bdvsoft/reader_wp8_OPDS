﻿#pragma checksum "C:\Читай 2\FBReader.App\Views\Controls\SearchResultItemControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A6464035C553A287974DF64BC11AB047"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.36279
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
    
    
    public partial class SearchResultItemControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.RichTextBox Text;
        
        internal System.Windows.Documents.Run TextBefore;
        
        internal System.Windows.Documents.Run SearchedText;
        
        internal System.Windows.Documents.Run TextAfter;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FBReader.App;component/Views/Controls/SearchResultItemControl.xaml", System.UriKind.Relative));
            this.Text = ((System.Windows.Controls.RichTextBox)(this.FindName("Text")));
            this.TextBefore = ((System.Windows.Documents.Run)(this.FindName("TextBefore")));
            this.SearchedText = ((System.Windows.Documents.Run)(this.FindName("SearchedText")));
            this.TextAfter = ((System.Windows.Documents.Run)(this.FindName("TextAfter")));
        }
    }
}

