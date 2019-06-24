using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vendido.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina : ContentPage
    {
        public Pagina()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Clicked(object sender, EventArgs e)
        {

        }
    }
}