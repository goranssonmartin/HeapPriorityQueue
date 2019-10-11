using NUnit.Framework;
using HeapPriorityQueue;
using System;

namespace HeapPriorityQueueTests
{
    public class Tests
    {
        [Test]
        public void CheckIfAddingAnIntegerWorks()
        {
            HeapPriorityQueueHandler<int> priorityQueueToTest = new HeapPriorityQueueHandler<int>();
            priorityQueueToTest.Add(5);
            Assert.AreEqual(5, priorityQueueToTest.Pop());
        }


        [Test]
        public void CheckIfAddingMultipleIntegersReturnsCorrectValue()
        {
            HeapPriorityQueueHandler<int> priorityQueueToTest = new HeapPriorityQueueHandler<int>();
            priorityQueueToTest.Add(5);
            priorityQueueToTest.Add(4);
            priorityQueueToTest.Add(10);
            priorityQueueToTest.Add(3);
            priorityQueueToTest.Add(2);
            priorityQueueToTest.Add(35);
            priorityQueueToTest.Add(1);
            priorityQueueToTest.Add(111);
            priorityQueueToTest.Add(120);
            Assert.AreEqual(1, priorityQueueToTest.Peek());
        }

        [Test]
        public void CheckifAddingStringReturnsCorrectValue() {
            HeapPriorityQueueHandler<string> priorityQueueToTest = new HeapPriorityQueueHandler<string>();
            priorityQueueToTest.Add("katt");
            Assert.AreEqual("katt",priorityQueueToTest.Pop());
        }

        [Test]
        public void CheckifAddingMultipleStringReturnsCorrectValues()
        {
            HeapPriorityQueueHandler<string> priorityQueueToTest = new HeapPriorityQueueHandler<string>();
            priorityQueueToTest.Add("katt");
            priorityQueueToTest.Add("katter");
            priorityQueueToTest.Add("hund");
            priorityQueueToTest.Add("kladdkaka");
            priorityQueueToTest.Add("citron");
            priorityQueueToTest.Add("äpple");
            priorityQueueToTest.Add("a");
            Assert.AreEqual("a", priorityQueueToTest.Pop());
        }

        [Test]
        public void CheckIfPopReturnsCorrectValue()
        {
            HeapPriorityQueueHandler<int> priorityQueueToTest = new HeapPriorityQueueHandler<int>();
            priorityQueueToTest.Add(5);
            priorityQueueToTest.Add(4);
            priorityQueueToTest.Add(10);
            priorityQueueToTest.Add(3);
            priorityQueueToTest.Add(2);
            priorityQueueToTest.Add(35);
            priorityQueueToTest.Add(1);
            priorityQueueToTest.Add(111);
            priorityQueueToTest.Add(120);
            Assert.AreEqual(1, priorityQueueToTest.Pop());
            Assert.AreEqual(2, priorityQueueToTest.Pop());
            Assert.AreEqual(3, priorityQueueToTest.Pop());
            Assert.AreEqual(4, priorityQueueToTest.Pop());
            Assert.AreEqual(5, priorityQueueToTest.Pop());
            Assert.AreEqual(10, priorityQueueToTest.Pop());
            Assert.AreEqual(35, priorityQueueToTest.Pop());
            Assert.AreEqual(111, priorityQueueToTest.Pop());
            Assert.AreEqual(120, priorityQueueToTest.Pop());
        }

        [Test]
        public void CheckIfPeekReturnsCorrectValue()
        {
            HeapPriorityQueueHandler<int> priorityQueueToTest = new HeapPriorityQueueHandler<int>();
            priorityQueueToTest.Add(5);
            priorityQueueToTest.Add(4);
            priorityQueueToTest.Add(10);
            priorityQueueToTest.Add(3);
            priorityQueueToTest.Add(2);
            priorityQueueToTest.Add(35);
            priorityQueueToTest.Add(1);
            priorityQueueToTest.Add(111);
            priorityQueueToTest.Add(120);
            Assert.AreEqual(1, priorityQueueToTest.Peek());
        }
        [Test]
        public void CheckIfPeekReturnsExceptionIfQueueIsEmpty()
        {
            HeapPriorityQueueHandler<int> priorityQueueToTest = new HeapPriorityQueueHandler<int>();
            Assert.That(() => priorityQueueToTest.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void CheckIfPopReturnsExceptionIfQueueIsEmpty()
        {
            HeapPriorityQueueHandler<int> priorityQueueToTest = new HeapPriorityQueueHandler<int>();
            Assert.That(() => priorityQueueToTest.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void CheckIfCountWorksIfQueueIsEmpty()
        {
            HeapPriorityQueueHandler<int> priorityQueueToTest = new HeapPriorityQueueHandler<int>();
            Assert.AreEqual(0,priorityQueueToTest.Count());
        }

        [Test]
        public void CheckIfCountWorks()
        {
            HeapPriorityQueueHandler<int> priorityQueueToTest = new HeapPriorityQueueHandler<int>();
            priorityQueueToTest.Add(5);
            priorityQueueToTest.Add(4);
            priorityQueueToTest.Add(10);
            priorityQueueToTest.Add(3);
            priorityQueueToTest.Add(2);
            priorityQueueToTest.Add(35);
            priorityQueueToTest.Add(1);
            priorityQueueToTest.Add(111);
            priorityQueueToTest.Add(120);
            Assert.AreEqual(9, priorityQueueToTest.Count());
        }
    }
}