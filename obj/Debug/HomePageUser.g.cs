﻿#pragma checksum "..\..\HomePageUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D2541FF17630411FC54CE9FDF0BFCAE91D8455246C72F5AA86288FA927327C90"
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


namespace complaintBox {
    
    
    /// <summary>
    /// loggedin
    /// </summary>
    public partial class loggedin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\HomePageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Registration;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\HomePageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label id;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\HomePageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\HomePageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label name;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\HomePageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Department;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\HomePageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox complaintType;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\HomePageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label date;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\HomePageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox complainBox;
        
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
            System.Uri resourceLocater = new System.Uri("/complaintBox;component/homepageuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HomePageUser.xaml"
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
            
            #line 11 "..\..\HomePageUser.xaml"
            ((complaintBox.loggedin)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Registration = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            
            #line 28 "..\..\HomePageUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.submitBtnClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.id = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.closeButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\HomePageUser.xaml"
            this.closeButton.Click += new System.Windows.RoutedEventHandler(this.closeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.name = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Department = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.complaintType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.date = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.complainBox = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 47 "..\..\HomePageUser.xaml"
            this.complainBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RichTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 55 "..\..\HomePageUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.logoutBtnClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
