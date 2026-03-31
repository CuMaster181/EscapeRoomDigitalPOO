using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoomDigitalPOO
{
    public class Item
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Image Imagen { get; set; }

        public Item(string id, string nombre, Image imagen)
        {
            Id = id;
            Nombre = nombre;
            Imagen = imagen;
        }
    }
}
