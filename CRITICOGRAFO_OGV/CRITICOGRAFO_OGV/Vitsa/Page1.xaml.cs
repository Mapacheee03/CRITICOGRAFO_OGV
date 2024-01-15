using CRITICOGRAFO_OGV.ViewModel;
using ExamenU4Daps.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRITICOGRAFO_OGV.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {


        public Page1()
        {
            InitializeComponent();
            BindingContext = new VMmenuprincipal(Navigation);
        }

      
    }
}
