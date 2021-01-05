using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinkedList
{
    /// <summary>
    /// this class will have the logic to connect
    /// the node objects to create link list structure
    /// </summary>
    public class SimpleLinkedList
    {
        /*Start node of the link list chain*/
        Node head = null;

        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.Data = data;

            if (head == null)
            {
                head = newItem;
                head.Next = null;
            }
            else
            {
                Node current = head;
                //loop and find the last node
                while (current.Next != null)
                {
                    current = current.Next;
                }
                //null this means this is the last nodex
                current.Next = newItem;
                newItem.Next = null;
            }
        }

        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.Data = data;

            //this is now the first item
            //so the current head becomes the next item 
            newItem.Next = head;

            //this newItem becomes the head
            head = newItem;
        }

        public void ReadAll()
        {
            Node current = head;
            //loop until the last node
            while (current.Next != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.WriteLine(current.Data);
        }
    }
}
