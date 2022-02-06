using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGBA.lesson2_1
{
    class LinkedList : ILinkedList
    {
        Node head;

        public void AddNode(int value)
        {
            Node newNode = new Node() { value = value };
            Node currentNode = head;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while (currentNode.nextItem != null)
                {
                    currentNode = currentNode.nextItem;
                }
                currentNode.nextItem = newNode;
                newNode.lastItem = currentNode;
            }
        }

        public void AddNodeAfter(Node node, int value)
        {
            Node newNode = new Node() { value = value };
            if (node.nextItem == null)
            {
                node.nextItem = newNode;
                newNode.lastItem = node;
            }
            else
            {
                Node nextNode = node.nextItem;
                node.nextItem = newNode;
                nextNode.lastItem = newNode;
                newNode.nextItem = nextNode;
                newNode.lastItem = node;
            }
        }

        public Node FindNode(int searchValue)
        {
            Node currentNode = head;
            if (currentNode == null)
            {
                Console.WriteLine("Список пуст, значение найти нельзя");
                return null;
            }
            while (currentNode.value != searchValue)
            {
                currentNode = currentNode.nextItem;
            }
            return currentNode;
        }

        public int GetCount()
        {
            Node currentNode = head;
            if (head == null)
            {
                return 0;
            }
            else
            {
                int count = 0;
                while (currentNode != null)
                {
                    count++;
                }
                return count;
            }
        }

        public void RemoveNode(int index)
        {
            if (head == null)
            {
                Console.WriteLine("Список элементов пусть, удалять нечего");
            }
            int indexFind = 1;
            Node currentNode = head;
            while (index != indexFind)
            {
                currentNode = currentNode.nextItem;
                indexFind++;
            }
            if (currentNode.nextItem == null)
            {
                currentNode.lastItem.nextItem = null;
            }
            else
            {

            }
        }

        public void RemoveNode(Node node)
        {
            if (node == head)
            {
                if (node.nextItem != null)
                {
                    head = node.nextItem;
                    node.nextItem.lastItem = null;
                }
                else
                {
                    head = null;
                }
            }
            else if (node.nextItem == null)
            {
                node.lastItem.nextItem = null;
            }
            else
            {
                node.lastItem.nextItem = node.nextItem;
                node.nextItem.lastItem = node.lastItem;
                node.lastItem = null;
                node.nextItem = null;
            }
        }
    }
}