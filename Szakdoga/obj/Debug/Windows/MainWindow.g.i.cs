﻿#pragma checksum "..\..\..\Windows\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "35123BBA9FC5CE5CF496CA64AFA6EA8FA366A3F009647E2A735EB1547CE4CD81"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 23 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Books;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Customers;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Cart;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_New_PW;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Logout;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdLista_konyv;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdLista_vasarlok;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Add_New;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Delete;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Mod;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSearch;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Search;
        
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
            System.Uri resourceLocater = new System.Uri("/Szakdoga;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainWindow.xaml"
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
            this.Button_Books = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Windows\MainWindow.xaml"
            this.Button_Books.Click += new System.Windows.RoutedEventHandler(this.Button_Books_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Button_Customers = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Windows\MainWindow.xaml"
            this.Button_Customers.Click += new System.Windows.RoutedEventHandler(this.Button_Customers_click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_Cart = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Windows\MainWindow.xaml"
            this.Button_Cart.Click += new System.Windows.RoutedEventHandler(this.Button_Cart_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button_New_PW = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\Windows\MainWindow.xaml"
            this.Button_New_PW.Click += new System.Windows.RoutedEventHandler(this.Button_New_PW_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Button_Logout = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Windows\MainWindow.xaml"
            this.Button_Logout.Click += new System.Windows.RoutedEventHandler(this.Button_Logout_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.grdLista_konyv = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.grdLista_vasarlok = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.Button_Add_New = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\..\Windows\MainWindow.xaml"
            this.Button_Add_New.Click += new System.Windows.RoutedEventHandler(this.Button_Add_New_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Button_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 154 "..\..\..\Windows\MainWindow.xaml"
            this.Button_Delete.Click += new System.Windows.RoutedEventHandler(this.Button_Delete_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Button_Mod = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\..\Windows\MainWindow.xaml"
            this.Button_Mod.Click += new System.Windows.RoutedEventHandler(this.btn_click_mod);
            
            #line default
            #line hidden
            return;
            case 12:
            this.TxtSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.Button_Search = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\..\Windows\MainWindow.xaml"
            this.Button_Search.Click += new System.Windows.RoutedEventHandler(this.Button_Search_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 94 "..\..\..\Windows\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_kosarhozad_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

