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
        public void Remove_StringFromArray_RemoveFromArray()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            string name = "Adam";
            string otherName = "Allison";
            string expected = "Allison";
            string actual;
            //act
            customlist.Add(name);
            customlist.Add(otherName);

            customlist.Remove("Adam");
            actual = customlist[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_AFewStringsFromArray_RemoveFromArray()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            string name = "Adam";
            string otherName = "Allison";
            string dogsName = "Hank";
            string catsName = "Praline";
            string expected = "Praline";
            string actual;
            //act
            customlist.Add(name);
            customlist.Add(otherName);
            customlist.Add(dogsName);
            customlist.Add(catsName);

            customlist.Remove("Adam");
            customlist.Remove("Hank");
            actual = customlist[1];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_FirstOfSameNumberFromArray_RemoveFromArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num = 5;
            int num1 = 20;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int num5 = 25;
            int expected = 20;
            int actual;
            //act
            customlist.Add(num);
            customlist.Add(num1);
            customlist.Add(num2);
            customlist.Add(num3);
            customlist.Add(num4);
            customlist.Add(num5);
            customlist.Remove(20);
            actual = customlist[3]; 
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_AllOfSameIntFromArray_RemoveFromArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num = 5;
            int num1 = 6;
            int expected = 6;
            int actual;
            //act
            customlist.Add(num);
            customlist.Add(num);
            customlist.Add(num);
            customlist.Add(num);
            customlist.Add(num);
            customlist.Add(num1);
            customlist.Remove(5);
            customlist.Remove(5);
            customlist.Remove(5);
            customlist.Remove(5);
            customlist.Remove(5);
            customlist.Remove(6);
            actual = customlist[0];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_MakeCountOfArray1_RemoveFromArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num = 5;
            int num1 = 6;
            int expected = 1;
            int actual;
            //act
            customlist.Add(num);
            customlist.Add(num1);
            customlist.Remove(num);
            actual = customlist.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_MakeStringCountOfArray1_RemoveFromArray()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            string firstName = "Adam";
            string lastName = "Nobs";
            string herFirstName = "Allison";
            string herLastName = "Raison";
            int expected = 1;
            int actual;
            //act
            customlist.Add(firstName);
            customlist.Add(lastName);
            customlist.Add(herFirstName);
            customlist.Add(herLastName);
            customlist.Remove(firstName);
            customlist.Remove(lastName);
            customlist.Remove(herFirstName);
            actual = customlist.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        /////////////////////////////////////////////////////////
    }
}
