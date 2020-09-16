
using System;
using System.Collections;

namespace Novelas_Literarias {
    /// <summary>
    /// ListaOrdenada es una estructura de datos dinámica parametrizada que tiene como característica
    /// principal el evitar el duplicado de datos. Ordena los datos con la implementación del método
    /// CompareTo() del tipo que se parametrice. 
    /// </summary>
    /// <typeparam name="T">Clase roja o tipo de dato que implemente IEquatable e IComparable</typeparam>
    public class ListaOrdenada<T> where T : IEquatable<T>, IComparable<T> {

        private Node<T> head;

        private int _intSize;

        /// <summary>
        /// Accesa a cualquier elemento de la lista.
        /// </summary>
        /// <param name="index">Indice para accesar a la lista</param>
        /// <returns>El objeto del nodo accesado</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public T this[int index] {
            get {
                if (EstaVacia || index >= Size)
                    throw new IndexOutOfRangeException("No existe el indice indicado.");
                Node<T> actual = head;
                var i = 0;
                while (i++ < index) actual = actual.NextNode;
                return actual.Objeto;
            }
        }
        /// <summary>
        /// Devuelve el tamaño de la lista
        /// </summary>
        public int Size {
            private set => _intSize = value;
            get => _intSize;
        }
        /// <summary>
        /// Devuelve true si la lista esta vacia o false en caso contrario
        /// </summary>
        public bool EstaVacia {
            get => head == null;
        }

        /// <summary>
        /// Limpia la lista y elimina todos los elementos
        /// </summary>
        public void Limpiar() {
            head = null;
            _intSize = 0;
        }
        /// <summary>
        /// Crea una lista ordenada vacia.
        /// </summary>
        public ListaOrdenada() {
            Limpiar(); //Mismo codigo, inecesario repetirlo
        }
        /// <summary>
        /// Crea una lista ordenada con N objetos a insertar directamente mediante
        /// el constructor
        /// </summary>
        /// <param name="objects"></param>
        public ListaOrdenada(params T[] objects) : this() {
            Agregar(objects);
        }
        /// <summary>
        /// Borra un elemento de la lista.
        /// </summary>
        /// <param name="obj">El elemento que se desea borrar</param>
        /// <returns>El elemento borrado</returns>
        public T Borrar(T obj) {
            if (EstaVacia)
                throw new Exception("Lista vacia. No se puede borrar ningun elemento.");
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
        /// <summary>
        /// Busca un elemento en la lista y lo devuelve si lo encontró.
        /// </summary>
        /// <param name="obj">Objeto a buscar</param>
        /// <returns>Objeto encontrado</returns>
        public T Buscar(T obj) {

            if (EstaVacia) {
                throw new Exception("Lista vacia");
            }

            Node<T> actual = head;
            while (actual.NextNode != null) {
                if (actual.Objeto.Equals(obj)) {
                    return actual.Objeto;
                }
                actual = actual.NextNode;
            }

            throw new Exception("Elemento no encontrado.");
        }
        /// <summary>
        /// Iterador de la lista. Recorre del principio a fin
        /// </summary>
        /// <returns>Cada elemento de la lista.</returns>
        public IEnumerator GetEnumerator() {
            if (EstaVacia)
                yield break;
            Node<T> nodoInicial = head;
            while (nodoInicial != null) {
                yield return nodoInicial.Objeto;
                nodoInicial = nodoInicial.NextNode;
            }

        }
        /// <summary>
        /// Agrega un elemento a la lista.
        /// </summary>
        /// <param name="obj">Objeto a agregar a la lista. <see cref="Agregar(T[])"/></param>
        /// <exception cref="Exception">No admite duplicados</exception>
        public void Agregar(T obj) {
            Node<T> nuevoNodo = new Node<T>(obj), prevNode = null, currentNode = head;
            while(currentNode!= null && currentNode.Objeto.CompareTo(obj) <= 0) {
                if (obj.Equals(currentNode.Objeto)) throw new Exception("No se permiten duplicados en esta lista.");
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
            }
            if(prevNode == null) {
                nuevoNodo.NextNode = head;
                head = nuevoNodo;
            } else {
                prevNode.NextNode = nuevoNodo;
                nuevoNodo.NextNode = currentNode;
            }
            _intSize++;
        }
        /// <summary>
        /// Agrega varios objetos a la vez a la lista.
        /// </summary>
        /// <param name="objs">Objetos a agregar a la lista (varios)</param>
        public void Agregar(params T[] objs) {
            foreach (T i in objs) {
                Agregar(i);
            }
        }
        /// <summary>
        /// Metodo que ejecuta las acciones en cada objeto
        /// </summary>
        /// <param name="action">Accion a ejecutar</param>
        public void ForEach(Action<T> action) {
            foreach (T i in this) {
                action.Invoke(i);
            }
        }
        /// <summary>
        /// Limpia la lista y elimina todo (GC)
        /// </summary>
        ~ListaOrdenada() {
            Limpiar();
        }

    }
}
