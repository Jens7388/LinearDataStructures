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
            queue.Push(queue, 1);
            queue.Push(queue, 2);
            queue.Push(queue, 3);
            queue.Push(queue, 4);
            queue.Push(queue, 5);
        }

        [Fact]
        public void TestPop()
        {
            Queue<int> queue = new(0);
            queue.Push(queue, 1);
            queue.Push(queue, 2);
            queue.Push(queue, 3);
            queue.Push(queue, 4);
            queue.Push(queue, 5);
            queue.Pop(queue);
        }
    }
}