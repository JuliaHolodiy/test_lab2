using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MySortInsertLib.Tests
{
    [TestClass]
    public class MySortInsertTests
    {
        //тесты для белого ящика
        [TestMethod]
        public void SortInsert_NotSorted_Even_length()
        {
            //arrange
            int[] mas = { 1, 2, 3, 4 };
            int[] expected = { 4, 3, 2, 1 };
            //act
            MySortInsert c = new MySortInsert();
            c.SortInsert(mas);
            //assert
            CollectionAssert.AreEqual(expected, mas);
        }

        [TestMethod]
        public void SortInsert_Empty()
        {
            //arrange
            int[] mas = { };
            int[] expected = { };
            //act
            MySortInsert c = new MySortInsert();
            c.SortInsert(mas);
            //assert
            CollectionAssert.AreEqual(expected, mas);
        }

        [TestMethod]
        public void SortInsert_One()
        {
            //arrange
            int[] mas = {1};
            int[] expected = {1};
            //act
            MySortInsert c = new MySortInsert();
            c.SortInsert(mas);
            //assert
            CollectionAssert.AreEqual(expected, mas);
        }

        [TestMethod]
        public void SortInsert_Sorted_Odd_length()
        {
            //arrange
            int[] mas = { 5, 4, 3, 2, 1 };
            int[] expected = { 5, 4, 3, 2, 1 };
            //act
            MySortInsert c = new MySortInsert();
            c.SortInsert(mas);
            //assert
            CollectionAssert.AreEqual(expected, mas);
        }

       /* //тесты для черного ящика
        [TestMethod]
        public void SortInsert_NotSorted_Even_length()
        {
            //arrange
            int[] mas = { 1, 2, 3, 4 };
            int[] expected = { 4, 3, 2, 1 };
            //act
            MySortInsert c = new MySortInsert();
            c.SortInsert(mas);
            //assert
            CollectionAssert.AreEqual(expected, mas);
        }

        [TestMethod]
        public void SortInsert_Empty()
        {
            //arrange
            int[] mas = { };
            int[] expected = { };
            //act
            MySortInsert c = new MySortInsert();
            c.SortInsert(mas);
            //assert
            CollectionAssert.AreEqual(expected, mas);
        }

        [TestMethod]
        public void SortInsert_One()
        {
            //arrange
            int[] mas = { 1 };
            int[] expected = { 1 };
            //act
            MySortInsert c = new MySortInsert();
            c.SortInsert(mas);
            //assert
            CollectionAssert.AreEqual(expected, mas);
        }

        [TestMethod]
        public void SortInsert_Sorted_Odd_length()
        {
            //arrange
            int[] mas = { 5, 4, 3, 2, 1 };
            int[] expected = { 5, 4, 3, 2, 1 };
            //act
            MySortInsert c = new MySortInsert();
            c.SortInsert(mas);
            //assert
            CollectionAssert.AreEqual(expected, mas);
        }*/
    }
}
