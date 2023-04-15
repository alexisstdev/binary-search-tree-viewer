using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Binary_Search_Tree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinarySearchTree()
        {
            Root = null;
        }

        ~BinarySearchTree()
        {
            Clear();
        }

        public Node<T> Root { get; set; }
        public bool Empty { get => Root == null; }

        public void Add(T dato)
        {
            if (Empty)
            {
                Root = new Node<T> { Data = dato };
                return;
            }

            Node<T> current = Root;

            while (true)
            {
                if (dato.CompareTo(current.Data) < 0)
                {
                    if (current.left == null)
                    {
                        current.left = new Node<T> { Data = dato };
                        break;
                    }
                    current = current.left;
                }
                else if (dato.CompareTo(current.Data) > 0)
                {
                    if (current.right == null)
                    {
                        current.right = new Node<T> { Data = dato };
                        break;
                    }
                    current = current.right;
                }
                else throw new Exception("This element is already in the tree");
            }
        }

        public T Search(T data)
        {
            foreach (T item in Preorder())
            {
                if (item.CompareTo(data) == 0) return item;
            }
            return default;
        }

        public void CreateDotFile()
        {
            if (Empty) return;

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

            foreach (T dato in Preorder()) txtDot += dato + $"[id={dato}]\n";

            txtDot += $"Root-> {Root.Data} [color = white];";

            //Cuerpo del .DOT
            TraverseNodes(Root);
            void TraverseNodes(Node<T> current)
            {
                if (current == null) return;

                if (current.left != null)
                {
                    txtDot += $"\n{current.Data} -> {current.left.Data} [color = white];";
                    TraverseNodes(current.left);
                }
                if (current.right != null)
                {
                    txtDot += $"\n{current.Data} -> {current.right.Data} [color = white];";
                    TraverseNodes(current.right);
                }
            }

            txtDot += "\n}";

            Directory.CreateDirectory("Dibujo/");
            StreamWriter sw;

            using (sw = new("Dibujo/Figura.dot"))
                sw.Write(txtDot);

            if (!Directory.Exists("Dibujar.bat"))
            {
                using (sw = new("Dibujar.bat"))
                    sw.Write("@echo off \ndel Dibujo/Figura.svg \ndot -Tsvg Dibujo/Figura.dot -o Dibujo/Figura.svg");
            }

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

        public void Remove(T dato)
        {
            RemoveRec(Root);

            Node<T> RemoveRec(Node<T> current)
            {
                if (current == null)
                    return current;
                if (dato.CompareTo(current.Data) < 0)
                    current.left = RemoveRec(current.left);
                else if (dato.CompareTo(current.Data) > 0)
                    current.right = RemoveRec(current.right);
                else
                {
                    if (current.left == null)
                        return current.right;
                    else if (current.right == null)
                        return current.left;
                    current.Data = MinValue(current.right);
                    current.right = RemoveRec(current.right);
                }

                return current;
                T MinValue(Node<T> current)
                {
                    T minv = current.Data;
                    while (current.left != null)
                    {
                        minv = current.left.Data;
                        current = current.left;
                    }
                    return minv;
                }
            }
        }

        public IEnumerable<T> Inorder()
        {
            return Inorder(Root);

            static IEnumerable<T> Inorder(Node<T> current)
            {
                if (current == null) yield break;

                foreach (var data in Inorder(current.left))
                {
                    yield return data;
                }

                yield return current.Data;

                foreach (var data in Inorder(current.right))
                {
                    yield return data;
                }
            }
        }

        public IEnumerable<T> Postorder()
        {
            return PostOrden(Root);

            static IEnumerable<T> PostOrden(Node<T> current)
            {
                if (current == null) yield break;

                foreach (var data in PostOrden(current.left))
                {
                    yield return data;
                }

                foreach (var dato in PostOrden(current.right))
                {
                    yield return dato;
                }

                yield return current.Data;
            }
        }

        public IEnumerable<T> Preorder()
        {
            return PreOrden(Root);

            static IEnumerable<T> PreOrden(Node<T> currenr)
            {
                if (currenr == null) yield break;

                yield return currenr.Data;

                foreach (var data in PreOrden(currenr.left))
                {
                    yield return data;
                }

                foreach (var data in PreOrden(currenr.right))
                {
                    yield return data;
                }
            }
        }

        public void Clear()
        {
            if (Empty) return;

            Clear(Root);
            Root = null;
            void Clear(Node<T> current)
            {
                if (current != null)
                {
                    Clear(current.left);
                    Clear(current.right);
                    Remove(current.Data);
                }
            }
        }
    }
}