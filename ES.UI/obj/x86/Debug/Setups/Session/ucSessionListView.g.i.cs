﻿#pragma checksum "..\..\..\..\..\Setups\Session\ucSessionListView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7211DB5C6C0AA442071C93577BAEE7F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ES.UI;
using ES.UI.Setups;
using ExtendedGrid.ExtendedColumn;
using ExtendedGrid.ExtendedGridControl;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ES.UI.Setups {
    
    
    /// <summary>
    /// ucSessionListView
    /// </summary>
    public partial class ucSessionListView : ES.UI.BaseUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\Setups\Session\ucSessionListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ES.UI.Setups.ucSessionListView SessionUserControl;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Setups\Session\ucSessionListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSession;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\Setups\Session\ucSessionListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRefreshSession;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\Setups\Session\ucSessionListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ExtendedGrid.ExtendedGridControl.ExtendedDataGrid gvSessionListView;
        
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
            System.Uri resourceLocater = new System.Uri("/ES.UI;component/setups/session/ucsessionlistview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Setups\Session\ucSessionListView.xaml"
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
            this.SessionUserControl = ((ES.UI.Setups.ucSessionListView)(target));
            return;
            case 2:
            this.btnAddSession = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\Setups\Session\ucSessionListView.xaml"
            this.btnAddSession.Click += new System.Windows.RoutedEventHandler(this.btnAddSession_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnRefreshSession = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\..\Setups\Session\ucSessionListView.xaml"
            this.btnRefreshSession.Click += new System.Windows.RoutedEventHandler(this.btnRefreshSession_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gvSessionListView = ((ExtendedGrid.ExtendedGridControl.ExtendedDataGrid)(target));
            return;
            case 5:
            
            #line 76 "..\..\..\..\..\Setups\Session\ucSessionListView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCMEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 81 "..\..\..\..\..\Setups\Session\ucSessionListView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCMView_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 82 "..\..\..\..\..\Setups\Session\ucSessionListView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCMDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
