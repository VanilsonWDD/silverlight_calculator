﻿#pragma checksum "c:\users\vanilson\documents\visual studio 2012\Projects\calculadora\calculadora\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7337D652036F9FF6F038468E954CE58D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace calculadora {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox txtFirstNumber;
        
        internal System.Windows.Controls.TextBox txtSecondNumber;
        
        internal System.Windows.Controls.RadioButton optAdd;
        
        internal System.Windows.Controls.RadioButton optSub;
        
        internal System.Windows.Controls.RadioButton optMult;
        
        internal System.Windows.Controls.RadioButton optDiv;
        
        internal System.Windows.Controls.Button btnCalculate;
        
        internal System.Windows.Controls.TextBox txtResult;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/calculadora;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtFirstNumber = ((System.Windows.Controls.TextBox)(this.FindName("txtFirstNumber")));
            this.txtSecondNumber = ((System.Windows.Controls.TextBox)(this.FindName("txtSecondNumber")));
            this.optAdd = ((System.Windows.Controls.RadioButton)(this.FindName("optAdd")));
            this.optSub = ((System.Windows.Controls.RadioButton)(this.FindName("optSub")));
            this.optMult = ((System.Windows.Controls.RadioButton)(this.FindName("optMult")));
            this.optDiv = ((System.Windows.Controls.RadioButton)(this.FindName("optDiv")));
            this.btnCalculate = ((System.Windows.Controls.Button)(this.FindName("btnCalculate")));
            this.txtResult = ((System.Windows.Controls.TextBox)(this.FindName("txtResult")));
        }
    }
}

