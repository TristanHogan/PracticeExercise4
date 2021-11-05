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
            var removeItem = deque.First.Value;
            deque.RemoveFirst();
            return removeItem;
        }
    }
}
