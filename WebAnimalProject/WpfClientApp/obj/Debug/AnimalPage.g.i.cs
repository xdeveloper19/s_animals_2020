﻿#pragma checksum "..\..\AnimalPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F934A44AEDD98C6EEF6B141E7C4C17859C82A24A3AA96FF30C12EB8B071D6976"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfClientApp;


namespace WpfClientApp {
    
    
    /// <summary>
    /// AnimalPage
    /// </summary>
    public partial class AnimalPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\AnimalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_first;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AnimalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edit_first;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AnimalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_second;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AnimalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edit_second;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AnimalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_third;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AnimalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edit_third;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AnimalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edit_search;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\AnimalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tb_list;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfClientApp;component/animalpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AnimalPage.xaml"
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
            this.txt_first = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.edit_first = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_second = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.edit_second = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_third = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.edit_third = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 30 "..\..\AnimalPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Add);
            
            #line default
            #line hidden
            return;
            case 8:
            this.edit_search = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 46 "..\..\AnimalPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Search);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tb_list = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            
            #line 77 "..\..\AnimalPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Load);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 84 "..\..\AnimalPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Delete);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

