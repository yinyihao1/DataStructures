using System;
using System.Diagnostics;

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


        /// <summary>
        /// 新增节点
        /// </summary>
        /// <param name="headNode">头节点</param>
        /// <param name="data">要增加节点数据</param>
        public void Add(Node<T> headNode,T data)
        {
            Node<T> add_node = new Node<T>() { Data=data};
            headNode.GetLastNode(headNode).Next = add_node;
        }

        public int GetLength(Node<T> headNode)
        {

            return 0;
        }

        public T Delete()
        {

            return default(T);
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
