using DSA.DSA;
using DSA.SinglyLinkedList;

namespace DSA
{
    internal class Program {
        public static void Main(string[] args) {

            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddFirst(10);
            list.AddFirst(99);
            list.AddLast(20);
            list.AddLast(30);
            list.AddAt(1, 15); // Add 15 at index 1

            Console.WriteLine("List after adding elements:");
            list.PrintList();

            list.RemoveFirst(); // Remove the first element
            Console.WriteLine("\nList after removing the first element:");
            list.PrintList();

            list.RemoveLast(); // Remove the last element
            Console.WriteLine("\nList after removing the last element:");
            list.PrintList();

            list.RemoveAt(1); // Remove the last element
            Console.WriteLine("\nList after removing the last element:");
            list.PrintList();

            //list.RemoveAt(1); // Remove element at index 1
            //Console.WriteLine("\nList after removing the element at index 1:");
            //PrintList(list);

        }
       

    }
}
