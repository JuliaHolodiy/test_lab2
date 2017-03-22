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
    }
}
