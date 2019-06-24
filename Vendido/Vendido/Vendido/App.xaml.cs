using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Vendido.ViewModels;
using Vendido.Views;
namespace Vendido
{
    public partial class App : Application
    {
        public static BaseDatos BD;
        public App()
        {
            string db = "productos.bd";
            string ruta = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), db);
            BD = new BaseDatos(ruta);

            InitializeComponent();

            MainPage = new NavigationPage(new Pagina());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
