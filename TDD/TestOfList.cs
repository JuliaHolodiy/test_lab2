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
    }
}
