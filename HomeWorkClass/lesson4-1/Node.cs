using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGBA.lesson4_1
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node<T> Parent { get; set; }
    }
}
