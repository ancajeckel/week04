using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Stack
    {
        public Stack()
        {
            StackList = new List<int>();
        }

        private List<int> StackList;

        public void Push(int aValue)
        {
            StackList.Add(aValue);
        }

        public int Pop()
        {
            if (StackList.Count > 0)
            {
                var stackPos = StackList[StackList.Count - 1];
                StackList.RemoveAt(StackList.Count - 1);
                return stackPos;
            }
            Console.WriteLine("Nothing to pop anymore!");
            return 0;
        }

        public void Print()
        {
            if (StackList == null || StackList.Count == 0)
            {
                Console.WriteLine("Stack empty!");
            }
            else
            {
                foreach (var item in StackList)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
