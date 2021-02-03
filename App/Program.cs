using DataStructures;

using System;
using System.Threading;

namespace App
{
    class Program
    {
        static void Main()
        {
            Stack<char> stack = new(3);
            Queue<char> queue = new(0);
            PrintQueue(queue);
            //CharSequence(stack);
            //TowerOfHanoi(stack);

        }
        private static void CharSequence(Stack<char> stack)
        {
            stack.Push('h');
            stack.Push('e');
            stack.Push('l');
            stack.Push('l');
            stack.Push('o');
            foreach(char c in stack.Items)
            {
                Console.Write(c);
            }
        }

        private static bool CheckIfPalindrome(Stack<char> stack)
        {
            stack.Push('r');
            stack.Push('e');
            stack.Push('j');
            stack.Push('e');
            stack.Push('r');

            int j = stack.Count - 1;
            for(int i = 0; i < stack.Count - 1; i++)
            {
                if(stack.Items[i] != stack.Items[j])
                {
                    return false;
                }
                j--;
            }
            return true;
        }

        private static void TowerOfHanoi(Stack<char> stack)
        {
            Move(stack.Count, 'A', 'C', 'B');
        }

        private static void Move(int n, char from_rod, char to_rod, char aux_rod)
        {
            if(n == 1)
            {
                Console.WriteLine("Move disk 1 from rod " +
                                  from_rod + " to rod " + to_rod);
                return;
            }
            Move(n - 1, from_rod, aux_rod, to_rod);
            Console.WriteLine("Move disk " + n + " from rod " +
            from_rod + " to rod " + to_rod);
            Move(n - 1, aux_rod, to_rod, from_rod);
        }

        private static void PrintQueue(Queue<char> queue)
        {
            queue.Add('H');
            queue.Add('e');
            queue.Add('l');
            queue.Add('l');
            queue.Add('o');
            queue.Add(' ');
            queue.Add('W');
            queue.Add('o');
            queue.Add('r');
            queue.Add('l');
            queue.Add('d');
            queue.Inverse();
            foreach(char c in queue.Items)
            {
                Console.Write(c);
                Thread.Sleep(500);
            }
        }
    }
}