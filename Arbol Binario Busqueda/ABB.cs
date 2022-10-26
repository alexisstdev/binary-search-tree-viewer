using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Arbol_Binario_Busqueda
{
    public class ArbolBB<T> where T : IComparable<T>
    {
        public ArbolBB()
        {
            Raiz = null;
        }

        ~ArbolBB()
        {
            Vaciar();
        }

        public Nodo<T> Raiz { get; set; }

        public bool Vacia { get => Raiz == null; }

        public T Buscar(T dato)
        {
            foreach (var item in PreOrden())
            {
                if (item.CompareTo(dato) == 0) return item;
            }
            return default;
        }

        public IEnumerable<T> InOrden()
        {
            return InOrden(Raiz);

            static IEnumerable<T> InOrden(Nodo<T> nodoActual)
            {
                if (nodoActual == null) yield break;

                foreach (var dato in InOrden(nodoActual.HijoIzq))
                {
                    yield return dato;
                }

                yield return nodoActual.Dato;

                foreach (var dato in InOrden(nodoActual.HijoDer))
                {
                    yield return dato;
                }
            }
        }

        public IEnumerable<T> PreOrden()
        {
            return PreOrden(Raiz);

            static IEnumerable<T> PreOrden(Nodo<T> nodoActual)
            {
                if (nodoActual == null) yield break;

                yield return nodoActual.Dato;

                foreach (var dato in PreOrden(nodoActual.HijoIzq))
                {
                    yield return dato;
                }

                foreach (var dato in PreOrden(nodoActual.HijoDer))
                {
                    yield return dato;
                }
            }
        }

        public IEnumerable<T> PostOrden()
        {
            return PostOrden(Raiz);

            static IEnumerable<T> PostOrden(Nodo<T> nodoActual)
            {
                if (nodoActual == null) yield break;

                foreach (var dato in PostOrden(nodoActual.HijoIzq))
                {
                    yield return dato;
                }

                foreach (var dato in PostOrden(nodoActual.HijoDer))
                {
                    yield return dato;
                }

                yield return nodoActual.Dato;
            }
        }

        public T Eliminar(T dato)
        {
            return default;
        }

        public void Vaciar()
        {
        }

        public void Agregar(T dato)
        {
            if (Vacia)
            {
                Raiz = new Nodo<T> { Dato = dato };
                return;
            }

            Nodo<T> nodoActual = Raiz;

            while (true)
            {
                if (dato.CompareTo(nodoActual.Dato) < 0)
                {
                    if (nodoActual.HijoIzq == null)
                    {
                        nodoActual.HijoIzq = new Nodo<T> { Dato = dato };
                        break;
                    }
                    nodoActual = nodoActual.HijoIzq;
                }
                else if (dato.CompareTo(nodoActual.Dato) > 0)
                {
                    if (nodoActual.HijoDer == null)
                    {
                        nodoActual.HijoDer = new Nodo<T> { Dato = dato };
                        break;
                    }
                    nodoActual = nodoActual.HijoDer;
                }
                else throw new Exception("No se aceptan duplicados");
            }
        }

        public void CrearArchivoDot()
        {
            if (Vacia) return;
            string txtDot = @"digraph Figura {
                bgcolor = gray15
                node [
                color = grey20
                fontsize = 12
                fontname = Arial
                fontcolor = white
                width = .7
                height = .7
                style = filled
                ]";
            foreach (var item in PreOrden())
            {
                txtDot += item + $"[id={item}]\n";
            }
            txtDot += "Raíz->  " + Raiz.Dato + " [ color = white ];";

            RecorrerNodos(Raiz);

            txtDot += "\n}";

            Directory.CreateDirectory("Figura/");

            using (StreamWriter sw = new("Figura/Figura.dot")) sw.Write(txtDot);

            Process.Start($"{Environment.CurrentDirectory}/Dibujar.bat.lnk").WaitForExit();

            void RecorrerNodos(Nodo<T> nodoActual)
            {
                if (nodoActual == null) return;
                if (nodoActual.HijoIzq != null)
                {
                    txtDot += $"\n{nodoActual.Dato} -> {nodoActual.HijoIzq.Dato} [color = white fontcolor = white ];";
                    RecorrerNodos(nodoActual.HijoIzq);
                }

                if (nodoActual.HijoDer != null)
                {
                    txtDot += $"\n{nodoActual.Dato} -> {nodoActual.HijoDer.Dato} [ color = white fontcolor = white];";
                    RecorrerNodos(nodoActual.HijoDer);
                }
            }
        }
    }
}

/*
Agregar Recursivo
public Nodo<T> Agregar(T dato, Nodo<T> raiz)
{
    if (raiz == null) return new Nodo<T> { Dato = dato };

    if (dato.CompareTo(raiz.Dato) < 0)
        raiz.HijoIzq = Agregar(dato, raiz.HijoIzq);

    if (dato.CompareTo(raiz.Dato) > 0)
        raiz.HijoDer = Agregar(dato, raiz.HijoDer);
    else throw new Exception("No se aceptan duplicados");

    return raiz;
}*/