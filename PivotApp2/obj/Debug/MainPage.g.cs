﻿#pragma checksum "C:\Users\Tamta\documents\visual studio 2012\Projects\PivotApp2\PivotApp2\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BEA159EB44C4CFB5D4CC4AE1DD5DA904"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PivotApp2 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button Button_Create;
        
        internal System.Windows.Controls.Button Button_Add_Item;
        
        internal System.Windows.Controls.Button Button_Delete_Item;
        
        internal System.Windows.Controls.Button Button_Get_All_Data_From_Base;
        
        internal System.Windows.Controls.Button Button_Delete_Base;
        
        internal Microsoft.Phone.Controls.LongListSelector longListSelector;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PivotApp2;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Button_Create = ((System.Windows.Controls.Button)(this.FindName("Button_Create")));
            this.Button_Add_Item = ((System.Windows.Controls.Button)(this.FindName("Button_Add_Item")));
            this.Button_Delete_Item = ((System.Windows.Controls.Button)(this.FindName("Button_Delete_Item")));
            this.Button_Get_All_Data_From_Base = ((System.Windows.Controls.Button)(this.FindName("Button_Get_All_Data_From_Base")));
            this.Button_Delete_Base = ((System.Windows.Controls.Button)(this.FindName("Button_Delete_Base")));
            this.longListSelector = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("longListSelector")));
        }
    }
}
