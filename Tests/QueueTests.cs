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
            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);
            queue.Add(5);
        }

        [Fact]
        public void TestPop()
        {
            Queue<int> queue = new(0);
            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);
            queue.Add(5);
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