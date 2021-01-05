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
    public class SimpleLinkedList<AnyTpe>
    {
        /*Start node of the link list chain*/
        Node<AnyTpe> head = null;
        Node<AnyTpe> tail = null;

        public void AddLast(AnyTpe data)
        {
            Node<AnyTpe> newItem = new Node<AnyTpe>();
            newItem.Data = data;

            if (head == null)
            {
                head = newItem;
                tail = newItem;
                //tail = head;
            }
            else
            {
                tail.Next = newItem;
                tail = newItem;
            }
        }

        public void AddFirst(AnyTpe data)
        {
            Node<AnyTpe> newItem = new Node<AnyTpe>();
            newItem.Data = data;

            if (head == null)
            {
                head = newItem;
                tail = newItem;
                //tail = head;
            }
            else
            {
                newItem.Next = head;

                //this newItem becomes the head
                head = newItem;
            }
           
        }

        public void ReadAll()
        {
            Node<AnyTpe> current = head;
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
