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

            if (linkedString == "")
            {
                linkedString += data.ToString();
            }
            else
            {
                linkedString += " -> " + data.ToString();
            }

            //linkedString += (linkedString == "" ? data.ToString() : " -> " + data.ToString());
            length += 1;
        }

        public void AddSorted(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }

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
            return "{ " + length.ToString() + " } " + linkedString;
        }

    }
}
