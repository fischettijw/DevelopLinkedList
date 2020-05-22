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
        Node myNode;

        public FrmTesting()
        {
            InitializeComponent();
        }

        private void FrmTesting_Load(object sender, EventArgs e)
        {
            Txt01.Text = "123";
            Txt02.Text = "29";
            Txt03.Text = "13";
            Txt04.Text = "28";
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            myNode = new Node(Convert.ToInt32(Txt01.Text));
            myNode.AddToEnd(Convert.ToInt32(Txt02.Text));
            myNode.AddToEnd(Convert.ToInt32(Txt03.Text));
            myNode.AddToEnd(Convert.ToInt32(Txt04.Text));

            LbxOutput.Items.Clear();
            LbxOutput.Items.Add(Node.length);
            LbxOutput.Items.Add(Node.linkedString);
            LbxOutput.Items.Add(myNode.ToString());
        }

    }


    //public class Inc
    //{
    //    static public int Num=0;
    //    public int A;
    //    public int B;

    //    public Inc(int a, int b)
    //    {
    //        A = a;
    //        B = b;
    //        Num += 1;
    //    }
    //}



}
