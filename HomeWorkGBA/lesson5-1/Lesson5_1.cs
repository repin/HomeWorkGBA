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

        public void Demo()
        {
            throw new NotImplementedException();
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
