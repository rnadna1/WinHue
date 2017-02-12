﻿#pragma checksum "..\..\..\..\..\..\Samples\Text\Views\MaskedTextboxView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "635B668EB76915258150F2CB83F4E11B"
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.LiveExplorer;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Xceed.Wpf.Toolkit.LiveExplorer.Samples.Text.Views {
    
    
    /// <summary>
    /// MaskedTextboxView
    /// </summary>
    public partial class MaskedTextboxView : Xceed.Wpf.Toolkit.LiveExplorer.DemoView, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\..\..\..\Samples\Text\Views\MaskedTextboxView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox _literals;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\..\Samples\Text\Views\MaskedTextboxView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox _prompt;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\..\Samples\Text\Views\MaskedTextboxView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _mask;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\..\Samples\Text\Views\MaskedTextboxView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _value;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\..\Samples\Text\Views\MaskedTextboxView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _text;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\..\..\Samples\Text\Views\MaskedTextboxView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.MaskedTextBox _maskedTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Xceed.Wpf.Toolkit.LiveExplorer;component/samples/text/views/maskedtextboxview.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Samples\Text\Views\MaskedTextboxView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this._literals = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this._prompt = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this._mask = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this._value = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this._text = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this._maskedTextBox = ((Xceed.Wpf.Toolkit.MaskedTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

