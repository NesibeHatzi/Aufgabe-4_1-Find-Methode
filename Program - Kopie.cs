using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4_GenerischerBaum
{
    class Program
    {
        static void Main(string[] args)
        {
    
            var tree = new Tree<String>();
            var root = tree.CreateNode("root");
            var child1 = tree.CreateNode("child1");
            var child2 = tree.CreateNode("child1");
            root.AppendChild(child1);
            root.AppendChild(child2);
            var grand11 = tree.CreateNode("grand11");
            var grand12 = tree.CreateNode("grand12");
            var grand13 = tree.CreateNode("grand13");
            child1.AppendChild(grand11);
            child1.AppendChild(grand12);
            child1.AppendChild(grand13);
            var grand21 = tree.CreateNode("grand21");
            child2.AppendChild(grand21);
            child1.RemoveChild(grand12);

root.PrintTree(); 
        }
    }

    class Tree<TType>{

        public TType _theObjects;
public List<Tree<TType>> _objectList = new List<Tree<TType>>();
      public Tree<TType> CreateNode(TType theObjects)
            {
                Tree<TType> node = new Tree<TType>();
               
                return node;
}
 

public void AppendChild(Tree<TType> child)
        {
            _objectList.Add(child); 
             
             
        }

        public void RemoveChild(Tree<TType> child)
        {
           _objectList.Remove(child);
        }

        public void PrintTree(String print = "")
        {
            Console.WriteLine(print + _theObjects);
            foreach (Tree<TType> child in _objectList)
            {
                child.PrintTree(print + "*");
            }

              public List<Tree<T>> Find(TType search, List<Tree<TType>> node = null)
        {
            if(node == null)
            {
                node = new List<Tree<TType>>();
            }

            if(_theObjects.Equals(search))
            {
                node.Add(this);
            }

            foreach(Tree<TType> child in _objectList)
            {
                child.Find(search, node);
            }

            return node;
        }

        public override string ToString()
        {
            return _theObjects.ToString();
}
        } 
    } 
}



