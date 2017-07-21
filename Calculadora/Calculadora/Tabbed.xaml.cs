using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabbed : TabbedPage
    {
        public Tabbed ()
        {
            InitializeComponent();
            

            var carb = new NavigationPage(new Carboidratos());
            carb.Title = "Carboidratos";
            Children.Add(carb);

            var carne = new NavigationPage(new Carnes());
            carne.Title = "Carnes";
            Children.Add(carne);
        }
    }
}