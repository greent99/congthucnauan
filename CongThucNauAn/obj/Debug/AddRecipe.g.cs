﻿#pragma checksum "..\..\AddRecipe.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27461C94092245FB68525B5E2EDF7CB0D9747D4A918FE5000C00D5ED69BCD7B3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CongThucNauAn;
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


namespace CongThucNauAn {
    
    
    /// <summary>
    /// AddRecipe
    /// </summary>
    public partial class AddRecipe : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelBtn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputTitle;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputUrl;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FileInput;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectFile;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputDescription;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputStep;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddStep;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputSteps;
        
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
            System.Uri resourceLocater = new System.Uri("/CongThucNauAn;component/addrecipe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddRecipe.xaml"
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
            this.CancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\AddRecipe.xaml"
            this.CancelBtn.Click += new System.Windows.RoutedEventHandler(this.CancelBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\AddRecipe.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.InputTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.InputUrl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.FileInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.SelectFile = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AddRecipe.xaml"
            this.SelectFile.Click += new System.Windows.RoutedEventHandler(this.SelectFile_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.InputDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.InputStep = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.AddStep = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\AddRecipe.xaml"
            this.AddStep.Click += new System.Windows.RoutedEventHandler(this.AddStep_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.InputSteps = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

