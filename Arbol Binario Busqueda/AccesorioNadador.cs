using System;

namespace Arbol_Binario_Busqueda
{
    public class AccesorioNadador : IComparable<AccesorioNadador>
    {
        public string Id { get; set; }
        public bool Ajustable { get; set; }
        public DateTime FechaCompra { get; set; }
        public char Categoria { get; set; }
        public string RutaImagen { get; set; }
        public string Material { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Talla { get; set; }
        public int Stock { get; set; }

        public int CompareTo(AccesorioNadador other)
        {
            return Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}