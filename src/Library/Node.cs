using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {

        private Persona persona;
        public Persona Persona {get;}
        private List<Node> children = new List<Node>();

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Persona persona)
        {
            this.persona = persona;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
    }
}
