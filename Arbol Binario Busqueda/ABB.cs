using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

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
        public bool Vacio { get => Raiz == null; }

        public void Agregar(T dato)
        {
            if (Vacio)
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
                else throw new Exception("Este elemento ya se encuentra en el árbol");
            }
        }

        public T Buscar(T dato)
        {
            foreach (T item in PreOrden())
            {
                if (item.CompareTo(dato) == 0) return item;
            }
            return default;
        }

        public void CrearArchivoDot()
        {
            if (Vacio) return;

            //Encabezado del .DOT
            string txtDot = @"digraph Figura {
                             bgcolor = transparent
                             node[
                             color = lightskyblue4
                             fontsize = 14
                             fontname = Arial
                             fontcolor = white
                             width = .7
                             height = .7
                             ]" + "\n";

            //Asigna un ID a cada elemento del .DOT
            foreach (T dato in PreOrden()) txtDot += dato + $"[id={dato}]\n";

            txtDot += $"Raíz-> {Raiz.Dato} [color = white];";

            //Cuerpo del .DOT
            RecorrerNodos(Raiz);
            void RecorrerNodos(Nodo<T> nodoActual)
            {
                if (nodoActual == null) return;

                if (nodoActual.HijoIzq != null)
                {
                    txtDot += $"\n{nodoActual.Dato} -> {nodoActual.HijoIzq.Dato} [color = white];";
                    RecorrerNodos(nodoActual.HijoIzq);
                }
                if (nodoActual.HijoDer != null)
                {
                    txtDot += $"\n{nodoActual.Dato} -> {nodoActual.HijoDer.Dato} [color = white];";
                    RecorrerNodos(nodoActual.HijoDer);
                }
            }

            //Final del .DOT
            txtDot += "\n}";

            //Crea el archivo .DOT y el archivo batch (en caso de que no exista)
            Directory.CreateDirectory("Dibujo/");
            StreamWriter sw;

            using (sw = new("Dibujo/Figura.dot"))
                sw.Write(txtDot);

            if (!Directory.Exists("Dibujar.bat"))
            {
                using (sw = new("Dibujar.bat"))
                    sw.Write("@echo off \ndel Dibujo/Figura.svg \ndot -Tsvg Dibujo/Figura.dot -o Dibujo/Figura.svg");
            }

            //Ejecuta el batch con la consola oculta
            Process process = new()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = $"{Environment.CurrentDirectory}/Dibujar.bat",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };

            process.Start();
            process.WaitForExit();
        }

        public void Eliminar(T dato)
        {
            EliminarRec(Raiz);

            Nodo<T> EliminarRec(Nodo<T> nodoActual)
            {
                if (nodoActual == null)
                    return nodoActual;
                if (dato.CompareTo(nodoActual.Dato) < 0)
                    nodoActual.HijoIzq = EliminarRec(nodoActual.HijoIzq);
                else if (dato.CompareTo(nodoActual.Dato) > 0)
                    nodoActual.HijoDer = EliminarRec(nodoActual.HijoDer);
                else
                {
                    if (nodoActual.HijoIzq == null)
                        return nodoActual.HijoDer;
                    else if (nodoActual.HijoDer == null)
                        return nodoActual.HijoIzq;
                    nodoActual.Dato = ValorMenor(nodoActual.HijoDer);
                    nodoActual.HijoDer = EliminarRec(nodoActual.HijoDer);
                }

                return nodoActual;
                T ValorMenor(Nodo<T> nodoActual)
                {
                    T minv = nodoActual.Dato;
                    while (nodoActual.HijoIzq != null)
                    {
                        minv = nodoActual.HijoIzq.Dato;
                        nodoActual = nodoActual.HijoIzq;
                    }
                    return minv;
                }
            }
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

        public void Vaciar()
        {
            if (Vacio) return;

            VaciarRec(Raiz);
            Raiz = null;
            void VaciarRec(Nodo<T> nodoActual)
            {
                if (nodoActual != null)
                {
                    VaciarRec(nodoActual.HijoIzq);
                    VaciarRec(nodoActual.HijoDer);
                    Eliminar(nodoActual.Dato);
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