using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Stack
    {
        private List<int> StackList;

        public void Push(int aValue)
        {
            if (StackList == null)
            {
                StackList = new List<int>();
            }

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
            if (StackList == null)
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
