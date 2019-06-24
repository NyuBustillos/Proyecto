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
    public partial class Pagina : ContentPage
    {
        public string ID = "";
        public Pagina()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (ID != "")
            {
                Producto producto = App.BD.ObtenerProducto(ID);
                txtNombre.Text = producto.Nombre;
                txtCantidad.Text = producto.Cantidad;
                txtPrecio.Text = producto.Precio;

            }
        }
        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string cantidad = txtCantidad.Text;
            string precio = txtPrecio.Text;

            App.BD.GuardarProducto(ID, nombre, precio, cantidad);
            Navigation.PopAsync();
        }

        private void BtnEliminar_Clicked(object sender, EventArgs e)
        {
            if (ID != "")
            {
                App.BD.EliminarProducto(ID);
                Navigation.PopAsync();
            }

        }
    }
}