using System;
using System.Collections.Generic;
namespace PracticeExercise4
{
    public class Deque<T> : IDeque<T>
    {
        private LinkedList<T> deque;
        
        public Deque()
        {
            deque = new LinkedList<T>();
        }

        public bool IsEmpty => deque.Count == 0 ? true : false;

        public int Length => deque.Count;


        public T Front => IsEmpty ? throw new EmptyQueueException() : deque.First.Value;

        public T Back => IsEmpty ? throw new EmptyQueueException() : deque.Last.Value;

        public void AddBack(T item)
        {
            deque.AddLast(item);
        }

        public void AddFront(T item)
        {
            deque.AddFirst(item);
        }

        public T RemoveBack()
        {
            var removeItem = deque.Last.Value;
            deque.RemoveLast();
            return removeItem;
        }

        public T RemoveFront()
        {
            if(deque.Count == 0)
            {
                throw new EmptyQueueException();
            }
            var removeItem = deque.First.Value;
            deque.RemoveFirst();
            return removeItem;
        }

        public override string ToString()
        {
            string result = "<Back> ";

            var currentNode = deque.Last;
            while (currentNode != null)
            {
                result += currentNode.Value;
                if (currentNode.Previous != null)
                {
                    result += " → ";
                }
                currentNode = currentNode.Previous;
            }

            result += " <Front>";

            return result;
        }
    }
}
