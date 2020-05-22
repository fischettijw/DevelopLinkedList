using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopLinkedList
{
    public class Node
    {

        public int data;
        public Node next;
        static public string linkedString = "";
        static public int length = 0;

        public Node(int i)
        {
            data = i;
            next = null;
            linkedString += data.ToString() + " -> ";
            length += 1;
        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }

        public override string ToString()
        {
            return "{ " + length.ToString() + " } " + linkedString.Substring(0, linkedString.Length - 4);
        }

    }
}
