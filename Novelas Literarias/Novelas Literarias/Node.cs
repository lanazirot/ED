
namespace Novelas_Literarias {
    class Node<T> {
        private Node<T> _nextNode;
        private T _obj;

        public T Objeto {
            get {
                return _obj;
            }
            set {
                _obj = value;
            }
        }

        public Node<T> NextNode {
            get {
                return _nextNode;
            }
            set {
                _nextNode = value;
            }
        }

        public Node(T obj) {
            this._obj = obj;
            this.NextNode = null;
        }

        ~Node() {
            _obj = default;
        }
    }
}
