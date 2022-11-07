using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
                if((START != null) && (rollNo == START.rollNumber))
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

            while((current != null) && (rollNo >= current.rollNumber))
            {
                if(rollNo == current.rollNumber)
                {

                }
            }
            

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
