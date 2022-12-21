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
            dimas = damar = null;
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

        static void Main(string[] args)
        {
            QueueLinkList myQueue = new QueueLinkList();
            char ch;

            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number: ");
                                int item = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                myQueue.Insert(item);
                            }
                            break;
                        case '2':
                            {
                                myQueue.Delete();
                            }
                            break;
                        case '3':
                            {
                                myQueue.Display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
                            break;


                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }


    }
}
