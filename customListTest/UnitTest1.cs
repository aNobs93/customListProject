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
            actual = (customlist.capacity = 4);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_IntToArray3_AddToArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num1 = 5;
            bool expected = (count == 1);
            bool actual;
            //act
            customlist.Add(num1);
            actual = (count == 1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_IntToArray4_AddToArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num1 = 5;
            bool expected = true;
            bool actual;
            //act
            customlist.Add(num1);
            actual = (customlist.capacity = 4);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
