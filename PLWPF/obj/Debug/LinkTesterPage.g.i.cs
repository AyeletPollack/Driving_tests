﻿#pragma checksum "..\..\LinkTesterPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C5FD11413391316AD583FB2315D4D9C8E09EA3B0912CCDC05CB2C9C4FDE6876"
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
    /// LinkTesterPage
    /// </summary>
    public partial class LinkTesterPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\LinkTesterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FamilyStatusbutton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\LinkTesterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IsActive;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\LinkTesterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Specialization;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\LinkTesterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Allbutton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\LinkTesterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCity;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\LinkTesterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxCity;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\LinkTesterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView myListAll;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\LinkTesterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView myListFamilyStatus;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\LinkTesterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView myListIsActive;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\LinkTesterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView myListSpecialization;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\LinkTesterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView myListCity;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/linktesterpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LinkTesterPage.xaml"
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
            this.FamilyStatusbutton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\LinkTesterPage.xaml"
            this.FamilyStatusbutton.Click += new System.Windows.RoutedEventHandler(this.FamilyStatus_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.IsActive = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\LinkTesterPage.xaml"
            this.IsActive.Click += new System.Windows.RoutedEventHandler(this.IsActive_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Specialization = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\LinkTesterPage.xaml"
            this.Specialization.Click += new System.Windows.RoutedEventHandler(this.Specialization_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Allbutton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\LinkTesterPage.xaml"
            this.Allbutton.Click += new System.Windows.RoutedEventHandler(this.Allbutton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.labelCity = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.comboBoxCity = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\LinkTesterPage.xaml"
            this.comboBoxCity.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBoxCity_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.myListAll = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.myListFamilyStatus = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.myListIsActive = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.myListSpecialization = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            this.myListCity = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

