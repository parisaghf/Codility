using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CostumList
    {
        /// <summary>
        ///  The class to represent each element in the linked list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        /// <summary>
        /// The class maintains a reference to the head node
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class MyCostumList<T>
        {
            private Node<T> head;

            public void Add(T item) 
            {
                var newNode = new Node<T>(item);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    var current = head;
                    while (current.Next != null)
                    {
                        current =current.Next;
                    }
                    current.Next = newNode;
                }
            }

            public void Remove(T item)
            {
                //var newNode = new Node<T>(item);
                //if (head == null)
                //{
                //    head = newNode;
                //}
                //else
                //{
                //    var current = head;
                //    while (current != null)
                //    {
                //        current.Next = newNode;
                //    }
                //    current.Next = newNode;
                //}
            }

            public void PrintAll()
            {
                var current = head;
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }
        }
    }
}
