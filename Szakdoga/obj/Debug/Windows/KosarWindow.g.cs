﻿#pragma checksum "..\..\..\Windows\KosarWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "558E3E8C9196A4B435F6A1A4DF29847618BA87995817879AEAC6224C54B533E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Szakdoga;


namespace Szakdoga {
    
    
    /// <summary>
    /// KosarWindow
    /// </summary>
    public partial class KosarWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\Windows\KosarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Szakdoga.KosarWindow Kosar_window;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Windows\KosarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtVasarloID;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows\KosarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_nev;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\KosarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_cim;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\KosarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_telefon;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\KosarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_email;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\KosarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_osszeg;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\KosarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdlista_kosar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Szakdoga;component/windows/kosarwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\KosarWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Kosar_window = ((Szakdoga.KosarWindow)(target));
            return;
            case 2:
            
            #line 17 "..\..\..\Windows\KosarWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_delete);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 18 "..\..\..\Windows\KosarWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Back);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\..\Windows\KosarWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Keres);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TxtVasarloID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TB_nev = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TB_cim = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.TB_telefon = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.TB_email = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.TB_osszeg = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            
            #line 32 "..\..\..\Windows\KosarWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Kiad);
            
            #line default
            #line hidden
            return;
            case 12:
            this.grdlista_kosar = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

