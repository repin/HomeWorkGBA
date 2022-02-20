using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGBA.lesson4_1
{
    interface ITree
    {
        void AddNode(int value);

        void DeleteNode(Node<int> node);

        Node<int> FindNode(int value);

    }
}
