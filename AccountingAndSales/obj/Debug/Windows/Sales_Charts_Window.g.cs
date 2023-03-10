#pragma checksum "..\..\..\Windows\Sales_Charts_Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1DC31176AE1C8A154D76A7BB44F9973F72DEF60089604FD6F6483BFFB9FBEA80"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AccountingAndSales.Views;
using DevExpress.Xpf.DXBinding;
using DevExpress.Xpf.Editors.DateNavigator.Controls;
using DevExpress.Xpf.Editors.Flyout.Native;
using DevExpress.Xpf.Editors.Helpers;
using DevExpress.Xpf.Editors.Internal;
using DevExpress.Xpf.Editors.RangeControl.Internal;
using Microsoft.Windows.Controls;
using RootLibrary.WPF.Localization;
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


namespace AccountingAndSales.Windows {
    
    
    /// <summary>
    /// Sales_Charts_Window
    /// </summary>
    public partial class Sales_Charts_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 111 "..\..\..\Windows\Sales_Charts_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox SalesChartType_GroupBox;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Windows\Sales_Charts_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SaleChartByDate_RadioButton;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\Windows\Sales_Charts_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SalesChartByCustomerName_RadioButton;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\Windows\Sales_Charts_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox SalesChartShowing_GroupBox;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\Windows\Sales_Charts_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ShowSalesChart_Grid;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\Windows\Sales_Charts_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl MainTab;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\Windows\Sales_Charts_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AccountingAndSales.Views.SalesChart_View salesChartForView;
        
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
            System.Uri resourceLocater = new System.Uri("/AccountingAndSales;component/windows/sales_charts_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\Sales_Charts_Window.xaml"
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
            
            #line 34 "..\..\..\Windows\Sales_Charts_Window.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 81 "..\..\..\Windows\Sales_Charts_Window.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 92 "..\..\..\Windows\Sales_Charts_Window.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 103 "..\..\..\Windows\Sales_Charts_Window.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SalesChartType_GroupBox = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 6:
            this.SaleChartByDate_RadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.SalesChartByCustomerName_RadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.SalesChartShowing_GroupBox = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 9:
            this.ShowSalesChart_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.MainTab = ((System.Windows.Controls.TabControl)(target));
            return;
            case 11:
            this.salesChartForView = ((AccountingAndSales.Views.SalesChart_View)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

