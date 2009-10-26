/* Author : Sushma Kyasaralli Thimmappa */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParallelPrototype
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node();//for a[1]=b[1]+c[1];
            n1.varName = "a[1]";
            n1.lhs = null;
            n1.rhs = null;
            Node n2 = new Node();
            n2.varName = "b[1]";
            n2.lhs = null;
            n2.rhs = null;
            Node n3 = new Node();
            n3.varName = "c[1]";
            n3.lhs = null;
            n3.rhs = null;
            Node n5 = new Node();
            n5.varName = "+";
            n5.lhs = n2;
            n5.rhs = n3;
            Node n4 = new Node(); //root
            n4.varName = "=";
            n4.lhs = n1;
            n4.rhs = n5;
            Node n6 = new Node();//for a[2]=b[2]*c[2];
            n6.varName = "a[2]";
            n6.lhs = null;
            n6.rhs = null;
            Node n7 = new Node();
            n7.varName = "b[2]";
            n7.lhs = null;
            n7.rhs = null;
            Node n8 = new Node();
            n8.varName = "c[2]";
            n8.lhs = null;
            n8.rhs = null;
            Node n9 = new Node();
            n9.varName = "*";
            n9.lhs = n7;
            n9.rhs = n8;
            Node n10 = new Node(); //root
            n10.varName = "=";
            n10.lhs = n6;
            n10.rhs = n9;     
            NodeTraversal nt = new NodeTraversal();
            string ss=(nt.preOrder(1,n4)).ToString();
            string ss1 = (nt.preOrder(1,n10)).ToString();
            Console.WriteLine("Preorder:{0} {1}", ss,ss1);
            string ss2 = (nt.inOrder(1, n4)).ToString();
            string ss3= (nt.inOrder(1, n10)).ToString();
            Console.WriteLine("Inorder:{0} {1}", ss2, ss3);
            Console.WriteLine("XML file for matrix data being constructed under bin");
            xmlDataSwarm x1 = new xmlDataSwarm();
            x1.writeToXml();
         }
    }
}
