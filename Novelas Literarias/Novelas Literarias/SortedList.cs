
using System;
using System.Collections;

namespace Novelas_Literarias {
    public class SortedList<T> where T : IEquatable<T>, IComparable<T> {

        private Node<T> head;

        private int _intSize;

        public T this[int index] {
            get {
                if (IsEmpty || index >= Size)
                    throw new Exception("Cant acess at this index.");
                Node<T> actual = head;
                var i = 0;
                while (i++ < index) actual = actual.NextNode;
                return actual.Objeto;
            }
        }

        public int Size {
            private set => _intSize = value;
            get => _intSize;
        }

        public bool IsEmpty {
            get => head == null;
        }

        public void Clear() {
            head = null;
            _intSize = 0;
        }

        public SortedList() {
            Clear(); //Mismo codigo, inecesario repetirlo
        }

        public SortedList(params T[] objects) : this() {
            Add(objects);
        }

        public T Delete(T obj) {
            if (IsEmpty)
                throw new Exception("Lista vacia");
            Node<T> aux = head, prev = null;

            while (aux != null && !aux.Objeto.Equals(obj)) {
                prev = aux;
                aux = aux.NextNode;
            }

            Node<T> ret;
            if (prev == null) {
                ret = head;
                head = head.NextNode;
            } else if (aux != null) {
                ret = prev.NextNode;
                prev.NextNode = aux.NextNode;
            } else throw new Exception("No se encontro el elemento a borrar");

            _intSize--;
            return ret.Objeto;
        }

        public T Search(T obj) {

            if (IsEmpty) {
                throw new Exception("Lista vacia");
            }

            Node<T> actual = head;
            while (actual.NextNode != null) {
                if (actual.Objeto.Equals(obj)) {
                    return actual.Objeto;
                }
                actual = actual.NextNode;
            }

            throw new Exception("Elemento no encontrado :(");
        }

        public IEnumerator GetEnumerator() {
            if (IsEmpty)
                yield break;
            Node<T> nodoInicial = head;
            while (nodoInicial != null) {
                yield return nodoInicial.Objeto;
                nodoInicial = nodoInicial.NextNode;
            }

        }

        public void Add(T obj) {
            Node<T> nuevoNodo = new Node<T>(obj);
            if (IsEmpty) {
                head = nuevoNodo;
            } else if (head.Objeto.CompareTo(obj) > 0) { //lt
                nuevoNodo.NextNode = head;
                head = nuevoNodo;
            } else { //gt
                Node<T> current = head;
                while (current.NextNode != null && current.NextNode.Objeto.CompareTo(obj) <= 0) {
                    current = current.NextNode;
                }
                if (current.Objeto.Equals(obj)) throw new Exception("No puedes insertar un mismo elemento dos veces");
                nuevoNodo.NextNode = current.NextNode;
                current.NextNode = nuevoNodo;
            }

            _intSize++;
        }

        public void Add(params T[] objs) {
            foreach (T i in objs) {
                Add(i);
            }
        }

        public void ForEach(Action<T> action) {
            foreach (T i in this) {
                action.Invoke(i);
            }
        }

        ~SortedList() {
            Clear();
        }

    }
}
