﻿#pragma checksum "..\..\Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6A93D6262C5B2E1BC2A23BD60A0E4EF8"
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
using InventoryManagementALEVEL.User_controls.Login_controls;
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
    /// Login
    /// </summary>
    public partial class Login : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label title_label;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forgotten_password_left_button;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button help_button;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button about_button;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button create_button;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button home_button;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl mainContentControl;
        
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
            System.Uri resourceLocater = new System.Uri("/InventoryManagementALEVEL;component/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Login.xaml"
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
            
            #line 9 "..\..\Login.xaml"
            ((InventoryManagementALEVEL.Login)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.title_label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.forgotten_password_left_button = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Login.xaml"
            this.forgotten_password_left_button.Click += new System.Windows.RoutedEventHandler(this.forgotten_password_button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.help_button = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Login.xaml"
            this.help_button.Click += new System.Windows.RoutedEventHandler(this.help_button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.about_button = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Login.xaml"
            this.about_button.Click += new System.Windows.RoutedEventHandler(this.about_button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.create_button = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\Login.xaml"
            this.create_button.Click += new System.Windows.RoutedEventHandler(this.create_button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.home_button = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\Login.xaml"
            this.home_button.Click += new System.Windows.RoutedEventHandler(this.home_button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mainContentControl = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

