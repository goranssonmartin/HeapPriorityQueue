using System;
using System.Collections.Generic;
using PriorityQueue;

namespace HeapPriorityQueue
{
    public class HeapPriorityQueueHandler<T> : IPriorityQueue<T> where T : IComparable, IComparable<T>
    {
        List<T> heapStoringList = new List<T>();
        public void Add(T value)
        {
            heapStoringList.Add(value);
            int currentIndex = Count() - 1;
            while (true)
            {
                int parentIndex = (currentIndex - 1) / 2;
                if (parentIndex >= 0 && heapStoringList[currentIndex].CompareTo(heapStoringList[parentIndex]) < 0)
                {
                    T temp = heapStoringList[currentIndex];
                    heapStoringList[currentIndex] = heapStoringList[parentIndex];
                    heapStoringList[parentIndex] = temp;

                    currentIndex = parentIndex;
                }
                else
                {
                    break;
                }
            }
        }

        public int Count()
        {
            return heapStoringList.Count;

        }

        public T Peek()
        {
            if (Count() <= 0)
            {
                throw new InvalidOperationException();
            }

            else
            {
                return heapStoringList[0];
            }
        }

        public T Pop()
        {
            if (heapStoringList.Count > 0)
            {
                T returnValue = heapStoringList[0];
                heapStoringList[0] = heapStoringList[Count() - 1];
                heapStoringList.RemoveAt(Count() - 1);
                int currentIndex = 0;
                int parentIndex = currentIndex;
                while (true)
                {
                    int indexOfLeftChild = (currentIndex * 2) + 1;
                    int indexOfRightChild = (currentIndex * 2) + 2;
                    if (indexOfLeftChild < Count() && heapStoringList[indexOfLeftChild].CompareTo(heapStoringList[currentIndex]) < 0)
                    {
                        parentIndex = indexOfLeftChild;
                    }

                    if (indexOfRightChild < Count() && heapStoringList[indexOfRightChild].CompareTo(heapStoringList[parentIndex]) < 0)
                    {
                        parentIndex = indexOfRightChild;
                    }

                    if (parentIndex != currentIndex)
                    {
                        T temp = heapStoringList[currentIndex];
                        heapStoringList[currentIndex] = heapStoringList[parentIndex];
                        heapStoringList[parentIndex] = temp;
                        currentIndex = parentIndex;
                    }
                    else
                    {
                        break;
                    }
                }
                return returnValue;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
