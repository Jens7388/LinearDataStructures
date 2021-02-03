using System;

using DataStructures;

using Xunit;

namespace Tests
{
    public class StackTests
    {
        [Fact]
        public void TestCreation()
        {
            Stack<int> stack = new(0);
        }

        [Fact]
        public void TestPush()
        {
            Stack<int> stack = new(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
        }

        [Fact]
        public void TestPop()
        {
            Stack<int> stack = new(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
        }
    }
}
