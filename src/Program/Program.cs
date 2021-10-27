using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Uno = new Persona("Pedro Uno", 80);
            Persona Dos = new Persona("Pedro Dos", 70);
            Persona Tres = new Persona("Pedro Tres", 60);
            Persona Cuatro = new Persona("Pedro Cuatro", 50);
            Persona Cinco = new Persona("Pedro Cinco", 40);
            Persona Seis = new Persona("Pedro Seis", 30);
            Persona Siete = new Persona("Pedro Siete", 20);
            Persona Ocho = new Persona("Pedro Ocho", 10);

            Node n1 = new Node(Uno);
            Node n2 = new Node(Dos);
            Node n3 = new Node(Tres);
            Node n4 = new Node(Cuatro);
            Node n5 = new Node(Cinco);
            Node n6 = new Node(Seis);
            Node n7 = new Node(Siete);
            Node n8 = new Node(Ocho);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n4.AddChildren(n8);

            // visitar el árbol aquí
        }
    }
}
