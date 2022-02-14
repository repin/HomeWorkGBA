using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGBA.lesson4_1
{
    class Lesson4_1 : ILesson
    {
        public string lessonID => "4-1";

        public string discriprions => "Построение двоичного дерева поиска с операциями.";

        public void Demo()
        {
            Tree tree = new Tree();
            //добавляем ноды (значения) в дерево
            tree.AddNode(8);
            tree.AddNode(10);
            tree.AddNode(15);
            tree.AddNode(12);
            tree.AddNode(17);
            tree.AddNode(19);
            tree.AddNode(16);
            tree.AddNode(4);
            tree.AddNode(9);
            tree.AddNode(7);
            //выводи дерево
            NodeInfo[] nodeInfo = tree.GetTreeInLine();
            Console.WriteLine();
            //Находим элемент
            Node<int> k = tree.FindNode(17);
            //Удаляем элемент
            tree.DeleteNode(k);
            //выводим дерево
            nodeInfo = tree.GetTreeInLine();
            Console.WriteLine();
            tree.AddNode(24);
            nodeInfo = tree.GetTreeInLine();
            foreach (NodeInfo nodeI in nodeInfo)
            {
                Console.WriteLine($"{nodeI.Depth}   {nodeI.Node.Data}");
            }
        }


    }
}
