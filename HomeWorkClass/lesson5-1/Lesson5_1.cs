using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkGBA.lesson4_1;

namespace HomeWorkGBA.lesson5_1
{
    class Lesson5_1 : ILesson
    {
        public string lessonID => "5-1";

        public string discriprions => "Чтения дерева методом BFS и DFS";


        /// <summary>
        /// Метод запускает тест реализации с выводом результатов в консоль. Метод генерирует дерево из ~25 элементов, выводит в деревоподобном виде, затем методами BFS И DFS.
        /// </summary>
        public void Demo()
        {
            Tree tree = new Tree();
            tree.AddNode(50);
            List<int> listNumbers = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                int l = new Random().Next(100);
                if (listNumbers.Contains(l))
                    continue;
                tree.AddNode(l);
                listNumbers.Add(l);
            }
            Console.WriteLine("Вывод дерева как в задании 4-1");
            tree.GetTreeInLine();
            Console.WriteLine("Выводим дерево методом BFS");
            readTreeBFS(tree.head);
            Console.WriteLine("Выводим дерево методом DFS");
            readTreeDFS(tree.head);

        }


        /// <summary>
        /// Метод выводит значения дерева используя подход BFS (очередь)
        /// </summary>
        /// <param name="head">корень дерева</param>
        public void readTreeBFS(Node<int> head)
        {
            Node<int> tmp;
            Queue<Node<int>> queue = new Queue<Node<int>>();
            queue.Enqueue(head);
            while (queue.Count != 0)
            {
                tmp = queue.Dequeue();
                Console.WriteLine(tmp.Data);
                if (tmp.Left != null)
                {
                    queue.Enqueue(tmp.Left);
                }
                if (tmp.Right != null)
                {
                    queue.Enqueue(tmp.Right);
                }
            }
        }


        /// <summary>
        /// Метод выводит значения дерева используя подход DFS (через stack)
        /// </summary>
        /// <param name="head">корень дерева</param>
        public void readTreeDFS(Node<int> head)
        {
            Node<int> tmp;
            Stack<Node<int>> stack = new Stack<Node<int>>();
            stack.Push(head);
            while (stack.Count != 0)
            {
                tmp = stack.Pop();
                Console.WriteLine(tmp.Data);
                if (tmp.Left != null)
                {
                    stack.Push(tmp.Left);
                }
                if (tmp.Right != null)
                {
                    stack.Push(tmp.Right);
                }
            }
        }
    }
}
