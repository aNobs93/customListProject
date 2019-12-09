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
        public void Remove_OneOfTheSameIntFromArray_RemoveFromArray()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int num = 5;
            int num1 = 6;
            bool expected = true;
            bool actual;
            //act


            customlist.Add(num);
            customlist.Add(num);
            customlist.Add(num);
            customlist.Add(num);
            customlist.Add(num);
            customlist.Add(num1);
            customlist.Remove(5);
            actual = (customlist[4] == 6);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_MakeCountOfArray1_RemoveFromArray()
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
        //Zip_List
        //[TestMethod]
        //public void Zip_ListOfIntsTogether_StringTogether()
        //{
        //    //arrange
        //    CustomList<int> odd = new CustomList<int>();
        //    CustomList<int> even = new CustomList<int>();
        //    CustomList<int> zipList = new CustomList<int>();
        //    int numOdd1 = 1;
        //    int numOdd2 = 3;
        //    int numOdd3 = 5;
        //    int numEven1 = 2;
        //    int numEven2 = 4;
        //    int numEven3 = 6;
        //    int expected = 6;
        //    int actual;
        //    //act
        //    odd.Add(numOdd1);
        //    odd.Add(numOdd2);
        //    odd.Add(numOdd3);
        //    even.Add(numEven1);
        //    even.Add(numEven2);
        //    even.Add(numEven3);
        //    odd.Zip(even);
        //    actual = zipList.Count;
        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        /////////////////////////////////
        //ToString 
        [TestMethod]
        public void ToString_OverrideString_ReturnListStrung()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            string oneLetter = "A";
            string twoLetters = "DA";
            string oneLetterAgain = "M";
            string expected= "A DA M";
            string actual;
            //act
            customlist.Add(oneLetter);
            customlist.Add(twoLetters);
            customlist.Add(oneLetterAgain);
            actual = customlist.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_OverrideToStringOfInts_ReturnListStrung()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int oneNum = 1;
            int secondNum = 2;
            int thirdNum = 3;
            string expected = "1 2 3";
            string actual;
            //act
            customlist.Add(oneNum);
            customlist.Add(secondNum);
            customlist.Add(thirdNum);
            actual = customlist.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_OverrideToStringOfIntsOneMoreTime_ReturnListStrung()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int oneNum = 9;
            int secondNum = 8;
            int thirdNum = 7;
            int fourthNum = 6;
            string expected = "9 8 7 6";
            string actual;
            //act
            customlist.Add(oneNum);
            customlist.Add(secondNum);
            customlist.Add(thirdNum);
            customlist.Add(fourthNum);
            actual = customlist.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_OverrideToStringOfStringsOneMoreTime_ReturnListStrung()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            string oneWord = "Hello";
            string secondWord = "World";
            string expected = "Hello World";
            string actual;
            //act
            customlist.Add(oneWord);
            customlist.Add(secondWord);
            actual = customlist.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        /////////////////////////////////////////
        //Overload + Operator
        [TestMethod]
        public void PlusOperator_OverLoadThePlusOperatorWithTwoLists_CombineIntoOneList()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            int numOne = 1;
            int numTwo = 2;
            int numThree = 3;
            int numFour = 4;
            int numFive = 5;
            int numSix = 6;
            string expected = ;
            string actual;
            //act
            one.Add(numOne);
            one.Add(numTwo);
            one.Add(numThree);
            two.Add(numFour);
            two.Add(numFive);
            two.Add(numSix);
            actual =;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
