﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHashrTable
{
    public class UC3
    {
        public Node top = null;


        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} Add element in Queue", value);
        }


        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

