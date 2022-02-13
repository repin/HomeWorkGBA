using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGBA.lesson4_1
{
    public class Tree : ITree
    {
        /// <summary>
        /// Поле, сохраняющее головной элемент дерева
        /// </summary>
        Node<int> head;

        /// <summary>
        /// Добавляет новый Node исходя из значения
        /// </summary>
        /// <param name="value">значение</param>
        public void AddNode(int value)
        {
            Node<int> tmp = null;
            if (head == null)
            {
                head = GetFreeNode(value);
                return;
            }
            tmp = head;
            while (tmp != null)
            {
                if (value > tmp.Data)
                {
                    if (tmp.Right != null)
                    {
                        tmp = tmp.Right;
                        continue;
                    }
                    else
                    {
                        tmp.Right = GetFreeNode(value, tmp);
                        return;
                    }
                }
                else if (value < tmp.Data)
                {
                    if (tmp.Left != null)
                    {
                        tmp = tmp.Left;
                        continue;
                    }
                    else
                    {
                        tmp.Left = GetFreeNode(value, tmp);
                        return;
                    }
                }
                else
                {
                    throw new Exception("Wrong tree state");
                }
            }
        }

        /// <summary>
        /// Поиск Node по значению
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns></returns>
        public Node<int> FindNode(int value)
        {
            Node<int> tmp;
            tmp = head;
            while (tmp.Data != value)
            {
                if (value < tmp.Data)
                {
                    if (tmp.Left != null)
                    {
                        tmp = tmp.Left;
                        continue;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    if (tmp.Right != null)
                    {
                        tmp = tmp.Right;
                        continue;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return tmp;
        }

        /// <summary>
        /// Удаление Нода
        /// </summary>
        /// <param name="node"></param>
        public void DeleteNode(Node<int> node)
        {
            Node<int> nodeP = node.Parent;
            if (nodeP.Left == node)
            {
                nodeP.Left = null;
            }
            else
            {
                nodeP.Right = null;
            }
            Node<int> nodeL = node.Left;
            Node<int> nodeR = node.Right;
            if (nodeL != null)
            {
                AddNode(nodeL);
            }
            if (nodeR != null)
            {
                AddNode(nodeR);
            }
        }

        /// <summary>
        /// Добавление Node в дерево
        /// </summary>
        /// <param name="node">Элемент, который необходимо добавить</param>
        public void AddNode(Node<int> node)
        {
            Node<int> tmp;
            tmp = head;
            while (tmp != null)
            {
                if (node.Data < tmp.Data)
                {
                    if (tmp.Left != null)
                    {
                        tmp = tmp.Left;
                        continue;
                    }
                    else
                    {
                        tmp.Left = node;
                        node.Parent = tmp;
                        return;
                    }
                }
                else if (node.Data > tmp.Data)
                {
                    if (tmp.Right != null)
                    {
                        tmp = tmp.Right;
                        continue;
                    }
                    else
                    {
                        tmp.Right = node;
                        node.Parent = tmp;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Создание нового нода
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="node">Ссылка на родителя</param>
        /// <returns></returns>
        private Node<int> GetFreeNode(int value, Node<int> node = null)
        {
            Node<int> newNode = new Node<int> { Data = value, Parent = node };
            return newNode;
        }


        public NodeInfo[] GetTreeInLine()
        {
            var bufer = new Queue<NodeInfo>();
            var returnArray = new List<NodeInfo>();
            var root = new NodeInfo() { Node = head };
            bufer.Enqueue(root);
            int k = 0;
            Console.WriteLine(head.Data);
            while (bufer.Count != 0)
            {
                var element = bufer.Dequeue();
                returnArray.Add(element);
                var depth = element.Depth + 1;
                if (k != depth-1)
                {
                    Console.WriteLine();
                    k++;
                }
                

                if (element.Node.Left != null)
                {
                    var left = new NodeInfo() { Node = element.Node.Left, Depth = depth };
                    Console.Write(element.Node.Left.Data+ " ");
                    bufer.Enqueue(left);
                }
                else
                {
                    Console.Write("null  ");
                }
                if (element.Node.Right != null)
                {
                    var right = new NodeInfo() { Node = element.Node.Right, Depth = depth };
                    Console.Write(element.Node.Right.Data + " ");
                    bufer.Enqueue(right);
                }
                else
                {
                    Console.Write("null  ");
                }

            }
            Console.WriteLine();
            return returnArray.ToArray();
        }


    }
    public class NodeInfo
    {
        public int Depth { get; set; }
        public Node<int> Node { get; set; }
    }
}
