using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopLinkedList
{
    class LinkedList
    {
        public Node headNode;
        static public int length;
        static public string linkedString = "";

        public LinkedList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
            length = Node.length;
        }

        public void AddToBeginning(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
            length = Node.length;
        }

        public override string ToString()
        {
            //return base.ToString();
            return headNode.ToString();
        }
    }
}
