using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinkedList
{
    /// <summary>
    /// this class represents a node 
    /// in the link list
    /// </summary>
    public class Node
    {
        public object Data = null;
        public Node Next = null;
    }

    public class Node<AnyType>
    {
        public AnyType Data;
        public Node<AnyType> Next;
    }
}
