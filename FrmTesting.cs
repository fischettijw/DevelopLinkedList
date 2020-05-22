using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevelopLinkedList
{
    public partial class FrmTesting : Form
    {

        string nodes = "";
        Node myNode;
        //Inc myClass = new Inc(0,1);

        public FrmTesting()
        {
            InitializeComponent();
        }

        private void FrmTesting_Load(object sender, EventArgs e)
        {
            Txt01.Text = "1";
            Txt02.Text = "2";
            Txt03.Text = "3";
            Txt04.Text = "4";
            myNode = new Node(0);
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            //string nodes = "";
            //Node myNode = new Node(Convert.ToInt32(Txt01.Text));
            //nodes += Txt01.Text + "->";
            //myNode.next = new Node(Convert.ToInt32(Txt02.Text));
            //myNode.next.next = new Node(Convert.ToInt32(Txt03.Text));
            //myNode.next.next.next = new Node(Convert.ToInt32(Txt04.Text));

            myNode.AddToEnd(Convert.ToInt32(Txt01.Text));
            nodes += Txt01.Text + "->";
            myNode.AddToEnd(Convert.ToInt32(Txt02.Text));
            nodes += Txt02.Text + "->";
            myNode.AddToEnd(Convert.ToInt32(Txt03.Text));
            nodes += Txt03.Text + "->";
            myNode.AddToEnd(Convert.ToInt32(Txt04.Text));
            nodes += Txt04.Text;

            //myClass = new Inc(2, 3);
            //myNode.AddToEnd(myClass);
            //myNode.AddToEnd(new Inc(3, 4));
            //myNode.AddToEnd(new Inc(5, 6));

            LbxOutput.Items.Clear();
            //myNode.Print(LbxOutput);
        }

        //public class Node
        //{
           
        //    public int data;
        //    public Node next;

        //    public Node(int i)
        //    {
        //            data = i;
        //            next = null;
        //    }

        //    public void Print(ListBox lbx)
        //    {
        //        string abc = this.ToString();

        //        lbx.Items.Add(data.ToString());
        //        if (next != null)
        //        {
        //            next.Print(lbx);
        //        }
        //    }

        //    public void AddToEnd(int data)
        //    {
        //        if (next == null)
        //        {
        //            next = new Node(data);
        //        }
        //        else
        //        {
        //            next.AddToEnd(data);
        //        }
        //    }

        //    public override string ToString()
        //    {
        //        return this.data.ToString();
        //    }

        //}
    }


    public class Inc
    {
        static public int Num=0;
        public int A;
        public int B;

        public Inc(int a, int b)
        {
            A = a;
            B = b;
            Num += 1;
        }
    }



}
