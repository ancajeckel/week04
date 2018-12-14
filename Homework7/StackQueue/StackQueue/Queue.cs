using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Queue
    {
        public Queue()
        {
            QueueList = new List<int>();
        }

        private List<int> QueueList;

        public void Enqueue(int aValue)
        {
            QueueList.Add(aValue);
        }

        public int Dequeue()
        {
            if (QueueList.Count > 0)
            {
                var queuePos = QueueList[0];
                QueueList.RemoveAt(0);
                return queuePos;
            }
            Console.WriteLine("Nothing to dequeue anymore!");
            return 0;
        }

        public void Print()
        {
            if (QueueList == null || QueueList.Count == 0)
            {
                Console.WriteLine("Queue empty!");
            }
            else
            {
                foreach (var item in QueueList)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
