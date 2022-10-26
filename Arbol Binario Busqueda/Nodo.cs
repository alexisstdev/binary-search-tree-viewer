namespace Arbol_Binario_Busqueda
{
    public class Nodo<T>
    {
        public T Dato { get; set; }
        public Nodo<T> HijoDer { get; set; }
        public Nodo<T> HijoIzq { get; set; }

        public Nodo()
        {
            HijoDer = null;
            HijoIzq = null;
            Dato = default;
        }

        ~Nodo()
        {
            Dato = default;
        }
    }
}