using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist_Example_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Developed By Hosein Mohamadpor");
            Console.ResetColor();

            Linkedlist L = new Linkedlist();

            L.head = new Node(38);//->data1
            Node sec= new Node(-56);//->data2
            Node thi= new Node(99);//->data3
            L.head.next = sec;//->pointer1
            sec.next = thi;//->pointer2
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Linkedlist Is :");
            L.print();
            Console.ResetColor();

            Console.WriteLine("\nEnter The Number To Be Added :");
            int nump = int.Parse(Console.ReadLine());
            L.push(nump);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nNow Linkedlist Is ( After Adding At First ) :");
            L.print();
            Console.ResetColor();
            Console.WriteLine(" ");

            L.AddAfter(70, L.head.next.next);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nNow Linkedlist Is ( After Adding At list [ 3 ] ) :");
            L.print();
            Console.ResetColor();
            Console.WriteLine(" ");

            Console.WriteLine("\nEnter The Number To Be Added :");
            int nume = int.Parse(Console.ReadLine());
            L.append(nume);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nNow Linkedlist Is ( After Adding At End ) :");
            L.print();
            Console.ResetColor();

            Console.WriteLine("\nEnter The Number To Be Deleted :");
            int numdn = int.Parse(Console.ReadLine());
            L.deln(numdn);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNow Linkedlist Is ( After Deleting Input Number ) :");
            L.print();
            Console.ResetColor();

            Console.WriteLine("\nEnter The Number To Be Deleted :");
            int numpn = int.Parse(Console.ReadLine());
            L.delp(numpn);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNow Linkedlist Is ( After Deleting Input Position ) :");
            L.print();
            Console.ResetColor();

            Console.ReadKey();

        }
    }
}
