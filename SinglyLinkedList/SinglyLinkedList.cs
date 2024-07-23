using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace DSA.SinglyLinkedList {
    public class SinglyLinkedList<T> {
        private class Node {
            public T Element;
            public Node Next;

            public Node(T element, Node next) {
                Element = element;
                Next = next;
            }
        }

        private Node Head;
        private Node Tail;
        private int Size = 0;

        public SinglyLinkedList() {

        }

        public int GetSize() => Size;

        

        public bool IsEmpty() => Size == 0;

        public T GetFirst() => IsEmpty() ? default(T) : Head.Element;

        public T GetLast() => IsEmpty() ? default(T) : Tail.Element;

        public void AddFirst(T element) {
            Head = new Node(element, Head);
            if (IsEmpty()) {
                Tail = Head;
            }
            Size++;
        }

        public void AddLast(T element) {
            Node newNode = new Node(element, null);

            if (IsEmpty()) {
                Head = newNode;
            } else {
                Tail.Next = newNode;
            }

            Tail = newNode;

            Size++;
        }

        public T RemoveFirst() {
            if (IsEmpty()) return default(T);

            T result = Head.Element;

            Head = Head.Next;

            Size--;

            if (IsEmpty()) {
                Tail = null;
            }

            return result;
        }

        public void AddAt(int index, T element) {
            if (index < 0 || index > Size) {
                throw new IndexOutOfRangeException(nameof(index));
            }

            if (index == 0) {
                AddFirst(element);
            } else if (index == Size) {
                AddLast(element);
            } else {
                Node prev = Head;

                for (int i = 0; i < index - 1; i++) {
                    prev = prev.Next;
                }
                Node newNode = new Node(element, prev.Next);
                prev.Next = newNode;

                Size++;
            }
        }

        public T RemoveLast() {
            if (IsEmpty()) return default(T);

            if (Size == 1) {
                T result = Head.Element;
                Head = null;
                Tail = null;
                Size--;

                return result;
            } else {
                Node prev = Head;

                for (int i = 0; i < Size - 2; i++) {
                    prev = prev.Next;
                }

                T result = prev.Element;

                Console.WriteLine(prev.Element);
                Tail = prev;

                Tail.Next = null;
                Console.WriteLine(Tail.Element);
                Size--;

                return result;
            }
        }

        public T RemoveAt(int index) {
            if (index < 0 || index >= Size) throw new IndexOutOfRangeException(nameof(index));

            if (index == 0) {
                return RemoveFirst();
            } else if (index == Size - 1) {
                return RemoveLast();
            } else {
                Node prev = Head;

                for (int i = 0; i < index - 1; i++) {
                    prev = prev.Next;
                }

                T result = prev.Next.Element;

                prev.Next = prev.Next.Next;

                Size--;

                return result;
            }

        }

        public void PrintList() {
            var current = Head;
            while (current != null) {
                Console.Write(current.Element + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
