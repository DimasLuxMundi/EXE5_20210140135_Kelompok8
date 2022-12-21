using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140135_Kelompok8
{
    internal class Node
    {
        internal int data;
        internal Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class QueueLinkList
    {
        Node dimas, damar;
        public QueueLinkList()
        {
            this.dimas = this.damar = null;
        }

        void Insert(int item)
        {
            Node newNode = new Node(item);

            if(damar == null)
            {
                dimas = damar = newNode;
            }
            else
            {
                damar.next = newNode;
                damar = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", item);
        }
        void Delete()
        {
            if (dimas == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Node current = dimas;
            dimas = dimas.next;

            Console.WriteLine("Item deleted is {0}", current.data);
        }

        void Display()
        {
            if(dimas == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Node current = dimas;
            while(current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }


    }
}
