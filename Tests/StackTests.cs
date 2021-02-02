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
            stack.Push(stack, 1);
            stack.Push(stack, 2);
            stack.Push(stack, 3);
            stack.Push(stack, 4);
            stack.Push(stack, 5);
        }

        [Fact]
        public void TestPop()
        {
            Stack<int> stack = new(0);
            stack.Push(stack, 1);
            stack.Push(stack, 2);
            stack.Push(stack, 3);
            stack.Push(stack, 4);
            stack.Push(stack, 5);
            stack.Pop(stack);
        }
    }
}
