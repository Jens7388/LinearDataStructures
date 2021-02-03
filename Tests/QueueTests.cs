using DataStructures;

using System;

using Xunit;

namespace Tests
{
    public class QueueTests
    {
        [Fact]
        public void TestCreation()
        {
            Queue<int> queue = new(0);
        }

        [Fact]
        public void TestPush()
        {
            Queue<int> queue = new(0);
            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            queue.Push(4);
            queue.Push(5);
        }

        [Fact]
        public void TestPop()
        {
            Queue<int> queue = new(0);
            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            queue.Push(4);
            queue.Push(5);
            queue.Pop();
        }

        [Fact]
        public void TestInverse()
        {
            Queue<int> queue = new(0);
            queue.Inverse();
        }
    }
}