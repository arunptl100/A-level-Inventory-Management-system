﻿#pragma checksum "..\..\AddNewItemWindowForSale.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C2FD02516F9ED5C5B01B0083E203B299"
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
    /// AddNewItemWindowForSale
    /// </summary>
    public partial class AddNewItemWindowForSale : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\AddNewItemWindowForSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock maintitle_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddNewItemWindowForSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ItemName_textBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddNewItemWindowForSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Quantity_textBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddNewItemWindowForSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker SellByDate_datePicker;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddNewItemWindowForSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Category_comboBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddNewItemWindowForSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_button;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AddNewItemWindowForSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reset_button;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AddNewItemWindowForSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancel_button;
        
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
            System.Uri resourceLocater = new System.Uri("/InventoryManagementALEVEL;component/addnewitemwindowforsale.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddNewItemWindowForSale.xaml"
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
            
            #line 8 "..\..\AddNewItemWindowForSale.xaml"
            ((InventoryManagementALEVEL.AddNewItemWindowForSale)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.maintitle_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ItemName_textBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\AddNewItemWindowForSale.xaml"
            this.ItemName_textBox.GotFocus += new System.Windows.RoutedEventHandler(this.ItemName_textBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Quantity_textBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\AddNewItemWindowForSale.xaml"
            this.Quantity_textBox.GotFocus += new System.Windows.RoutedEventHandler(this.Quantity_textBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SellByDate_datePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.Category_comboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\AddNewItemWindowForSale.xaml"
            this.Category_comboBox.DropDownClosed += new System.EventHandler(this.Category_comboBox_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 7:
            this.add_button = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\AddNewItemWindowForSale.xaml"
            this.add_button.Click += new System.Windows.RoutedEventHandler(this.add_button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.reset_button = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\AddNewItemWindowForSale.xaml"
            this.reset_button.Click += new System.Windows.RoutedEventHandler(this.reset_button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cancel_button = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\AddNewItemWindowForSale.xaml"
            this.cancel_button.Click += new System.Windows.RoutedEventHandler(this.cancel_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

