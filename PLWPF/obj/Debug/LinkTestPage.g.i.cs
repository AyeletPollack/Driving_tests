﻿#pragma checksum "..\..\LinkTestPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3D9D6C9A8C13DB46275CFED6D4FB85A80DC222237C24B63321C9CF735BE15A09"
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
    /// LinkTestPage
    /// </summary>
    public partial class LinkTestPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\LinkTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DateTesTesterId;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\LinkTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DateTesTestResult;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\LinkTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DateTest;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\LinkTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Allbutton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\LinkTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView myListAll;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\LinkTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView myListMounth;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\LinkTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView myListTestResult;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\LinkTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView myListTesterId;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/linktestpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LinkTestPage.xaml"
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
            this.DateTesTesterId = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\LinkTestPage.xaml"
            this.DateTesTesterId.Click += new System.Windows.RoutedEventHandler(this.DateTesTesterId_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DateTesTestResult = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\LinkTestPage.xaml"
            this.DateTesTestResult.Click += new System.Windows.RoutedEventHandler(this.DateTesTestResult_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DateTest = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\LinkTestPage.xaml"
            this.DateTest.Click += new System.Windows.RoutedEventHandler(this.DateTest_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Allbutton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\LinkTestPage.xaml"
            this.Allbutton.Click += new System.Windows.RoutedEventHandler(this.Allbutton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.myListAll = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.myListMounth = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.myListTestResult = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.myListTesterId = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

