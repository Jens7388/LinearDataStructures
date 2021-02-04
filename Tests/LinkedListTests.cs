using DataStructures;

using System;

using Xunit;

namespace Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void TestCreation()
        {
            LinkedList<Node<int>> list = new(5);
        }

        [Fact]
        public void TestReplaceFirst()
        {
            Node<int> node = new(5);
            Node<int> newNode = new(6);
            LinkedList<int> list = new(1);
            list.Insert(node, 0);
            list.ReplaceFirst(newNode);
        }

        [Fact]
        public void TestReplaceRest()
        {
            LinkedList<int> list = new(4);
            LinkedList<int> replacement = new(3);
            Node<int> first = new(1);
            list.Insert(first, 0);
            for(int i = 0; i < replacement.Count; i++)
            {
                replacement.Insert(new Node<int>(3), i);
            }
            list.ReplaceRest(replacement);
        }

        [Fact]
        public void TestRemove()
        {
            LinkedList<int> list = new(4);
            list.Insert(new Node<int>(1), 0);
            list.Insert(new Node<int>(2), 1);
            list.Insert(new Node<int>(3), 1);
            list.Insert(new Node<int>(4), 3);
            list.Remove(2);
        }
    }
}
