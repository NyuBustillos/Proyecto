﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vendido.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaProductos : ContentPage
    {
        public ListaProductos()
        {
            InitializeComponent();
        }

        private void LsvProductos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void BtnNuevo_Clicked(object sender, EventArgs e)
        {

        }
    }
}