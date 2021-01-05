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
    public class SimpleLinkedListTail
    {
        /*Start node of the link list chain*/
        Node head = null;
        Node tail = null;

        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.Data = data;

            //step 1:- FirstItem
            //head --> newItem
            //tail --> newItem

            if (head == null)
            {
                head = newItem;
                tail = newItem;
                //tail = head;
            }
            else
            {
                //step2:- SecondItem
                //current tail next item is set to
                //to newItem. the current tail
                //is set to newItem 
                tail.Next = newItem;
                tail = newItem;
            }
        }

        public void AddFirst(object data)
        {
            Node newItem = new Node();
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
