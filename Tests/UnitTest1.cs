using DataStructures;

using System;

using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCreation()
        {
            List<int> list = new(10);
        }

        [Fact]
        public void TestInsert()
        {
            List<int> list = new(10);
            list.Insert(1, 1);
        }

        [Fact]
        public void TestRemove()
        {
            List<int> list = new(10);
            list.Remove(4);
        }

        [Fact]
        public void TestResizeTo()
        {
            List<int> list = new(10);
            list.ResizeTo(5);
        }
    }
}
