﻿#pragma checksum "..\..\..\Test\TestPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "366898727AA4B64425609E26A5101E62A347700E31525C9ACB18A3FC98CBC044"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PLWPF;
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


namespace PLWPF {
    
    
    /// <summary>
    /// TestPage
    /// </summary>
    public partial class TestPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Test\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Test\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addTestButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Test\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteTestButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Test\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateTestButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Test\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showButton;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/test/testpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Test\TestPage.xaml"
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
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.addTestButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Test\TestPage.xaml"
            this.addTestButton.Click += new System.Windows.RoutedEventHandler(this.addTestButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.deleteTestButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Test\TestPage.xaml"
            this.deleteTestButton.Click += new System.Windows.RoutedEventHandler(this.deleteTestButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.updateTestButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Test\TestPage.xaml"
            this.updateTestButton.Click += new System.Windows.RoutedEventHandler(this.updateTestButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.showButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Test\TestPage.xaml"
            this.showButton.Click += new System.Windows.RoutedEventHandler(this.showButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
