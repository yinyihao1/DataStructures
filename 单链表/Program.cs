using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单链表
{
    class Program
    {
        static void Main(string[] args)
        {
            int _data = 0;
            Node<int> headNode = new Node<int>() { Data = _data++ };
            for (int i = 0; i < 10; i++)
            {
                headNode.Add(headNode, _data++);
            }
            Console.WriteLine(headNode.GetLastNode(headNode).Data);
        }
    }

    /// <summary>
    /// 单链表节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }


        public void Add(Node<T> headNode,T data)
        {
            Node<T> add_node = new Node<T>() { Data=data};
            headNode.GetLastNode(headNode).Next = add_node;
        }

        public Node<T> GetLastNode(Node<T> headNode)
        {
            if (headNode.Next == null)
            {
                return headNode;
            }
            //else
            //{
            //    return GetLastNode(headNode.Next);
            //}
            //or 
            while (headNode.Next!=null)
            {
                headNode= GetLastNode(headNode.Next);
            }
            return headNode;
        }
    }
}
