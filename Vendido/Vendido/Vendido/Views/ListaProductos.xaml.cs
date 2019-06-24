using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Vendido.ViewModels;

namespace Vendido.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaProductos : ContentPage
    {
        public ListaProductos()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lsvProductos.ItemsSource = App.BD.ObtenerProducto();
        }

        private void LsvProductos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Producto producto = e.SelectedItem as Producto;
                Pagina pagina = new Pagina();
                pagina.ID = producto.ID;
                Navigation.PushAsync(pagina);

            }
        }

        private void BtnNuevo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina());
        }
    }
}