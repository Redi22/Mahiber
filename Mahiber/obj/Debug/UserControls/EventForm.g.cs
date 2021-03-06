﻿#pragma checksum "..\..\..\UserControls\EventForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F794806734455F31A0BC76E50B9237E69DFBE731"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Mahiber.UserControls;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Mahiber.UserControls {
    
    
    /// <summary>
    /// EventForm
    /// </summary>
    public partial class EventForm : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker EventDate;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventPlace;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker EventTime;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventFin;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Description;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBtn;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtn;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refreshBtn;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EventGrid;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn NameColunm;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DateColunm;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn PlaceColunm;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn FinColunm;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DescriptionColunm;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Attendance;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\UserControls\EventForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AttendanceForm;
        
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
            System.Uri resourceLocater = new System.Uri("/Mahiber;component/usercontrols/eventform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\EventForm.xaml"
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
            this.EventName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.EventDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.EventPlace = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.EventTime = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 5:
            this.EventFin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\UserControls\EventForm.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.EditBtn = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\UserControls\EventForm.xaml"
            this.EditBtn.Click += new System.Windows.RoutedEventHandler(this.EditBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DeleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\UserControls\EventForm.xaml"
            this.DeleteBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 92 "..\..\..\UserControls\EventForm.xaml"
            this.Search.KeyUp += new System.Windows.Input.KeyEventHandler(this.Search_KeyUp);
            
            #line default
            #line hidden
            return;
            case 11:
            this.refreshBtn = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\UserControls\EventForm.xaml"
            this.refreshBtn.Click += new System.Windows.RoutedEventHandler(this.refreshBtn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.EventGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 112 "..\..\..\UserControls\EventForm.xaml"
            this.EventGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EventGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.NameColunm = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 14:
            this.DateColunm = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 15:
            this.PlaceColunm = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 16:
            this.FinColunm = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 17:
            this.DescriptionColunm = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 18:
            this.Attendance = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\..\UserControls\EventForm.xaml"
            this.Attendance.Click += new System.Windows.RoutedEventHandler(this.Attendance_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.AttendanceForm = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

