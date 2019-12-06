using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;
namespace customListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_IntToArray_AddToArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num = 5;
            int expected = 5;
            int actual;
            //act
            customlist.Add(num);
            actual = customlist[0];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_IntToArray2_AddToArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num1 = 5;
            bool expected = true;
            bool actual;
            //act
            customlist.Add(num1);
            actual = (customlist.Capacity == 4);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_IntToArray3_AddToArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num1 = 5;
            bool expected = true;
            bool actual;
            //act
            customlist.Add(num1);
            actual = (customlist.Count == 1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_StringToArray_AddToArray()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            string word = "help";
            bool expected = true;
            bool actual;
            //act
            customlist.Add(word);
            actual = (customlist.Capacity == 4);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_StringToArray2_AddToArray()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            string word = "help";
            bool expected = true;
            bool actual;
            //act
            customlist.Add(word);
            actual = (customlist.Count == 1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_IntToArray4_AddToArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num = 5;
            int num1 = 6;
            int expected = 6;
            int actual;
            //act
            customlist.Add(num);
            customlist.Add(num1);
            actual = customlist[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_IntToArray5_AddToArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num = 5;
            bool expected = true;
            bool actual;
            //act
            customlist.Add(num);
            customlist.Add(num);
            customlist.Add(num);
            customlist.Add(num);
            customlist.Add(num);
            actual = (customlist.Capacity == 8);
            //assert
            Assert.AreEqual(expected, actual);
        }
        //////////////////////////////////////////////////////
        [TestMethod]
        public void Remove_IntFromArray_RemoveFromArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num = 5;
            bool expected = true;
            bool actual;
            //act
            customlist.Add(num);
            customlist.Remove(num);
            actual = (customlist.Count == 0);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_IntFromEmptyArray_RemoveFromArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num = 5;
            bool expected = false;
            bool actual;
            //act
            actual = customlist.Remove(num);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
