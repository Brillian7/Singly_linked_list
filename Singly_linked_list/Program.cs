using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Singly_linked_list
{
    //each nude consist of the information part and link to the next nude
    class node
    {
        public int rollNumber;
        public string name;
        public node next;
    }

    class list
    {
        node START;
        public list()
        {
            START = null;
        }
        public void addNote()
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll name of the student: ");
            nm = Console.ReadLine();
            node newnode = new node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            //if the node to be inserted is the first node
            if ((START == null || rollNo <= START.rollNumber))
            {
                if ((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

            node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (rollNo >= current.rollNumber))
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine();
                    return;
                }

                previous.next = current;
                previous.next = newnode;
            }
        }
        public bool delNode(int rollNo)
        {
            node previous, current;
            previous = current = null;
            if (search(rollNo, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;
        }

        public bool search(int rollNo, ref node previous, ref node current)
        {
            previous = START;
            current = START;
            while((current != null) && (rollNo >= current.rollNumber))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return false;
            else
                return true;
        }
        public void  Traverse()
        {
            if(listEmpty())
                Console.WriteLine("\nThe records in the list are: ");
            else
            {
                Console.WriteLine("\nThe records in the list are: ");
                node currenntNode;
                for (currenntNode = START; currenntNode != null; currenntNode = currenntNode.next)
                    Console.Write(currenntNode.rollNumber + "" + currenntNode.name + "\n");
                Console.WriteLine();
            }
        }
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }

        
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            list obj = new list();

        }
    }
}
