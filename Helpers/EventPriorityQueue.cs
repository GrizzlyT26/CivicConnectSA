
using System.Collections.Generic;
using CivicConnectSA.Models;

namespace CivicConnectSA.Helpers
{
    public class EventPriorityQueue
    {
        // Smaller numbers represent higher priority.
        private readonly SortedDictionary<int, Queue<LocalEvent>>
            priorities =
                new SortedDictionary<int, Queue<LocalEvent>>();

        private int count = 0;

        public int Count
        {
            get { return count; }
        }

        public void Enqueue(LocalEvent localEvent, int priority)
        {
            if (localEvent == null)
                return;

            if (!priorities.ContainsKey(priority))
            {
                priorities.Add(
                    priority,
                    new Queue<LocalEvent>());
            }

            // Events with equal priority are processed FIFO.
            priorities[priority].Enqueue(localEvent);
            count++;
        }

        public LocalEvent Dequeue()
        {
            if (count == 0)
                return null;

            // SortedDictionary returns priorities in ascending order.
            int highestPriorityKey = 0;

            foreach (int priority in priorities.Keys)
            {
                highestPriorityKey = priority;
                break;
            }

            Queue<LocalEvent> queue =
                priorities[highestPriorityKey];

            LocalEvent nextEvent = queue.Dequeue();

            if (queue.Count == 0)
            {
                priorities.Remove(highestPriorityKey);
            }

            count--;

            return nextEvent;
        }

        public void Clear()
        {
            priorities.Clear();
            count = 0;
        }
    }
}
