﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7D6D69C82AA6EBA741130B5D041FE7E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using InventoryManagementALEVEL;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace InventoryManagementALEVEL {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 82 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle topbar_Rectangle;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl mainContentControl;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close_button;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button maximize_button;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimize_button;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock windowtitle;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Main_Menu_button;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Inventory_button;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button For_Sale_button;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Performance_button;
        
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
            System.Uri resourceLocater = new System.Uri("/InventoryManagementALEVEL;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 9 "..\..\MainWindow.xaml"
            ((InventoryManagementALEVEL.MainWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.topbar_Rectangle = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 82 "..\..\MainWindow.xaml"
            this.topbar_Rectangle.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.topbar_Rectangle_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mainContentControl = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 4:
            this.close_button = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\MainWindow.xaml"
            this.close_button.Click += new System.Windows.RoutedEventHandler(this.close_button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.maximize_button = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\MainWindow.xaml"
            this.maximize_button.Click += new System.Windows.RoutedEventHandler(this.maximize_button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.minimize_button = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\MainWindow.xaml"
            this.minimize_button.Click += new System.Windows.RoutedEventHandler(this.minimize_button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.windowtitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Main_Menu_button = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\MainWindow.xaml"
            this.Main_Menu_button.Click += new System.Windows.RoutedEventHandler(this.Main_Menu_button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Inventory_button = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\MainWindow.xaml"
            this.Inventory_button.Click += new System.Windows.RoutedEventHandler(this.Inventory_button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.For_Sale_button = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\MainWindow.xaml"
            this.For_Sale_button.Click += new System.Windows.RoutedEventHandler(this.For_Sale_button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Performance_button = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\MainWindow.xaml"
            this.Performance_button.Click += new System.Windows.RoutedEventHandler(this.Performance_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

