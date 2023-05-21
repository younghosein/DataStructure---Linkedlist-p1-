using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Linkedlist_Example_0
{
    class Linkedlist
    {
        public Node head;

        public void print()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data+" . ");
                n = n.next;
            }
        }
        //-
        public void push(int nd)
        {
            Node nn = new Node(nd);

            nn.next = head;
            head = nn;
        }

        public void AddAfter(int nd,Node bn)
        {
            if (bn == null)
            {
                Console.WriteLine("vojodesho ndre ddsh!");
                return;
            }
            Node nn = new Node(nd);

            nn.next = bn.next;

            bn.next = nn;
        }

        public void append(int nd)
        {
            Node nn = new Node(nd);

            if (head == null)
            {
                head = new Node(nd);
                return;
            }

            nn.next = null;

            Node last = head;

            while (last.next != null)
            {
                last = last.next;
            }

            last.next = nn;

        }
        public void deln(int d)
        {
            Node n = head;
            Node t = null;

            //if (n != null && n.data == d)
            {
                head = n.next;
                return;
            }
            while (n != null && n.data != d)
            {
                t = n;
                n = n.next;
            }
            //if (n == null)
            {
                return;
            }
            t.next = n.next;
        }

        public void delp(int p)
        {
            if (head == null)
            {
                return;
            }
            Node n = head;
            if (p == 0)
            {
                head = n.next;
                return;
            }
            for(int i = 0; n != null && i < p - 1; i++)
            {
                n = n.next;
            }
            if (n == null || n.next == null)
            {
                return;
            }
            Node nxt = n.next.next;
            n.next = nxt;
        }
    }
}
