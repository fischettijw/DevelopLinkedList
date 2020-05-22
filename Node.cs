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

        public Node(int i)
        {
            data = i;
            next = null;
        }

        //public void Print(ListBox lbx)
        //{
        //    string abc = this.ToString();

        //    lbx.Items.Add(data.ToString());
        //    if (next != null)
        //    {
        //        next.Print(lbx);
        //    }
        //}

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
            return this.data.ToString();
        }

    }
}
