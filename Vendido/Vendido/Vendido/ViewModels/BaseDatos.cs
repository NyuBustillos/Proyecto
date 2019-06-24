using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using System.Collections.ObjectModel;
using SQLite;

namespace Vendido.ViewModels
{
    class BaseDatos : SQLiteConnection
    {
        public BaseDatos(string path) : base(path)
        {
            CrearTablas();
        }
        void CrearTablas()
        {
            CreateTable<Producto>();
        }

        public ObservableCollection<Producto> ObtenerProducto()
        {
            return new
                ObservableCollection<Producto>(this.Table<Producto>().ToList());
        }
        public Producto ObtenerProducto(string id)
        {
            if (id == "")
                return new Producto();
            else
                return Table<Producto>().Where(t => t.ID == id).First();
        }
        public void GuardarProducto(string id, string nombre, string precio, string cantidad)
        {
            Producto producto = ObtenerProducto(id);
            producto.Nombre = nombre;
            producto.Precio = precio;
            producto.Cantidad = cantidad;
            if (id == "")
                AgregarProducto(producto);
            else
                ActualizarProducto(producto);
        }
        private void AgregarProducto(Producto producto)
        {
            producto.ID = Guid.NewGuid().ToString();
            this.Insert(producto);
        }
        public void ActualizarProducto(Producto producto)
        {
            this.Update(producto);
        }
        public void EliminarProducto(string id)
        {
            Producto producto = Table<Producto>().Where(t => t.ID == id).First();
            this.Delete(producto);
        }
    }
}
