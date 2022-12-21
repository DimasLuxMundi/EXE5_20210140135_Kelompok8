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

            if(this.damar == null)
            {
                this.dimas = this.damar = newNode;
            }
            else
            {
                this.damar.next = newNode;
                this.damar = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", item);
        }
        void Delete()
        {
            if (this.dimas == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Node current = this.dimas;
            this.dimas = this.dimas.next;

            Console.WriteLine("Item deleted is {0}", current.data);
        }


    }
}
