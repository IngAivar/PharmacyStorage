#pragma checksum "..\..\Win_2_1_New-Order.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E4A3C7F19B80640E960C60698EB260640E826E4C65A2D1E7AF6CDAE06BB26B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Project_Pharmacy;
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


namespace Project_Pharmacy {
    
    
    /// <summary>
    /// Win_2_1_New_Order
    /// </summary>
    public partial class Win_2_1_New_Order : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Win_2_1_New-Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Pochta;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Win_2_1_New-Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cart;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Win_2_1_New-Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Telefon;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Win_2_1_New-Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Famil;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Win_2_1_New-Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Ima;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Win_2_1_New-Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdStufer;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Win_2_1_New-Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdCust;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Win_2_1_New-Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Enty;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Win_2_1_New-Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdCust_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/Project_Pharmacy;component/win_2_1_new-order.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Win_2_1_New-Order.xaml"
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
            
            #line 8 "..\..\Win_2_1_New-Order.xaml"
            ((Project_Pharmacy.Win_2_1_New_Order)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Pochta = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Cart = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Win_2_1_New-Order.xaml"
            this.Cart.Click += new System.Windows.RoutedEventHandler(this.ButtonClickShopCart);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 16 "..\..\Win_2_1_New-Order.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonClickBack);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Telefon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Famil = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Ima = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.IdStufer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.IdCust = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Enty = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Win_2_1_New-Order.xaml"
            this.Enty.Click += new System.Windows.RoutedEventHandler(this.ButtonClEnter);
            
            #line default
            #line hidden
            return;
            case 11:
            this.IdCust_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

