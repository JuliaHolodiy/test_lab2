using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListApp;

namespace TDD
{
    [TestClass]
    public class TestOfList
    {
        [TestMethod]
        public void CreateLinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            //Assert.IsInstanceOfType(linkedList, LinkedList<string>);
        }

        [TestMethod]
        public void CreateNode()
        {
            Node<string> node = new Node<string>();
            //Assert.IsInstanceOfType(linkedList, LinkedList<string>);
        }

        [TestMethod]
        public void Add()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("Vasya");
            Assert.AreEqual("Vasya", list.head.Data);
        }
        [TestMethod]
        public void Empty()
        {
            LinkedList<string> list = new LinkedList<string>();
            bool result = list.Empty();
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void NotEmpty()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("Vasya");
            bool result = list.Empty();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Contains()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("Vasya");
            bool result=list.Contains("Vasya");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CountOfArrayFromOneEl()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("Vasya");
            Assert.AreEqual(1, list.Count);
        }
        [TestMethod]
        public void CountOfEmptyArray()
        {
            LinkedList<string> list = new LinkedList<string>();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void DeleteFromArrayOfOne()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("Vasya");
            bool res = list.Delete("Vasya");
            Assert.AreEqual(true, res);
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void DeleteFromArrayOfTwo()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("Vasya");
            list.Add("Petya");
            bool res = list.Delete("Petya");
            LinkedList<string> expected = new LinkedList<string>();
            expected.Add("Vasya");
            Assert.AreEqual(true, res);
            Assert.AreEqual(expected.head.Data, list.head.Data);
        }

        [TestMethod]
        public void DeleteFromArrayOfThree()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("Vasya");
            list.Add("Petya");
            list.Add("Kolya");
            bool res = list.Delete("Petya");
            LinkedList<string> expected = new LinkedList<string>();
            expected.Add("Vasya");
            expected.Add("Kolya");
            Assert.AreEqual(true, res);
            Assert.AreEqual(expected.head.Data, list.head.Data);
            Assert.AreEqual(expected.tail.Data, list.tail.Data);
        }

        [TestMethod]
        public void DeleteFromArrayOfFour()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("Vasya");
            list.Add("Petya");
            list.Add("Ann");
            list.Add("Kolya");
            bool res = list.Delete("Ann");
            LinkedList<string> expected = new LinkedList<string>();
            expected.Add("Vasya");
            expected.Add("Petya");
            expected.Add("Kolya");
            Assert.AreEqual(true, res);
            Assert.AreEqual(expected.head.Data, list.head.Data);
            Assert.AreEqual(expected.head.Next.Data, list.head.Next.Data);
            Assert.AreEqual(expected.tail.Data, list.tail.Data);
        }
    }
}
