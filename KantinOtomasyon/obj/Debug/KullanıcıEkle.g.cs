#pragma checksum "..\..\KullanıcıEkle.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "60B40D43AF329B961B41CFA782553DB098861B8B0EEDBF3222E3E6BA98988E43"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using KantinOtomasyon;
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


namespace KantinOtomasyon {
    
    
    /// <summary>
    /// KullanıcıEkle
    /// </summary>
    public partial class KullanıcıEkle : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\KullanıcıEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\KullanıcıEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSurname;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\KullanıcıEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\KullanıcıEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCardNumber;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\KullanıcıEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\KullanıcıEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbUserType;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\KullanıcıEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridView1;
        
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
            System.Uri resourceLocater = new System.Uri("/KantinOtomasyon;component/kullan%c4%b1c%c4%b1ekle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KullanıcıEkle.xaml"
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
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtCardNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cbUserType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 23 "..\..\KullanıcıEkle.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 28 "..\..\KullanıcıEkle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dataGridView1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 29 "..\..\KullanıcıEkle.xaml"
            this.dataGridView1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridView1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

