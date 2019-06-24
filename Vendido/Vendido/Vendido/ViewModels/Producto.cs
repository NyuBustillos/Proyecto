using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;
using SQLite;

namespace Vendido.ViewModels
{
    [Table("Producto")]
    class Producto
    {
        [PrimaryKey]
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Cantidad { get; set; }


    }
}
