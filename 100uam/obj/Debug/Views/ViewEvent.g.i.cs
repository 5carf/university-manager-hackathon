﻿#pragma checksum "..\..\..\Views\ViewEvent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BA9DADFB0BE2BB848E01392688CB4DABE77BD9E0"
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
using _100uam.Views;


namespace _100uam.Views {
    
    
    /// <summary>
    /// ViewEvent
    /// </summary>
    public partial class ViewEvent : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Views\ViewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image eventCover;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\ViewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image eventAvatar;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\ViewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock questTitle;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\ViewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock questDescription;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\ViewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel costStackPanel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\ViewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel rewardStackPanel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\ViewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button questAcceptButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\ViewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button questDeclineButton;
        
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
            System.Uri resourceLocater = new System.Uri("/100uam;component/views/viewevent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ViewEvent.xaml"
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
            this.eventCover = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.eventAvatar = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.questTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.questDescription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.costStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.rewardStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.questAcceptButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Views\ViewEvent.xaml"
            this.questAcceptButton.Click += new System.Windows.RoutedEventHandler(this.questAcceptButtonbClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.questDeclineButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Views\ViewEvent.xaml"
            this.questDeclineButton.Click += new System.Windows.RoutedEventHandler(this.questDeclineButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

