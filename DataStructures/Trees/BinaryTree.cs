using System;
using System.Collections.Generic;
using DataStructures.Queue;
using System.Linq;

namespace DataStructures.Trees
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node Root { get; set; }
        public IEnumerable<T> PreOrder(Node Root)
        {
            if (Root is null)
            {
                yield break;
            }
            
            foreach(T thing in PreOrder(Root.Left))
            {
                yield return thing; 
            }
            foreach(T thing in PreOrder(Root.Right))
            {
                yield return thing; 
            }
        }

        public IEnumerable<T> InOrder(Node Root)
        {
            if (Root is null)
            {
                yield break;
            }
            if (Root != null)
            {
                foreach(T thing in InOrder(Root.Left))
                {
                    yield return thing; 
                }
                yield return Root.Value;

                foreach(T thing in InOrder(Root.Left))
                {
                    yield return thing; 
                }
            }
        }

        public IEnumerable<T> PostOrder(Node Root)
        {
            if (Root is null)
            {
                yield break;
            }
            if (Root != null)
            {
                foreach (T thing in PostOrder(Root.Left))
                {
                    yield return thing; 
                } 
                foreach (T thing in PostOrder(Root.Right))
                {
                    yield return thing; 
                }
                yield return Root.Value;
            }
        }


        //public override string ToString()
        //{
        //    return string.Join(", ", PreOrder(Root, new Queue<T>()));
        //}

       public IEnumerable<T> BreadthFirst()
        {
            if(Root is null)
            {
                yield break; 
            }

            DataStructures.Queue.Queue<Node> breadthFirstTraversal = new DataStructures.Queue.Queue<Node>();
            breadthFirstTraversal.Enqueue(Root);

            while(!breadthFirstTraversal.IsEmpty())
            {
                var front = breadthFirstTraversal.Dequeue();
                yield return front.Value;

                if(front.Left != null)
                {
                    breadthFirstTraversal.Enqueue(front.Left); 
                }
                else if(front.Right != null)
                {
                    breadthFirstTraversal.Enqueue(front.Right); 
                }
            }
        }

        public class Node
        {
            public T Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node Root { get; set; }

        }
    }

  
}