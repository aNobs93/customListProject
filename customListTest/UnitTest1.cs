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
        //RemoveRange
        [TestMethod]
        public void RemoveRange_MakeStringRemoveRangeAndLeaveTwoStrings_RemoveFromArray()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            string firstName = "Adam";
            string lastName = "Nobs";
            string herFirstName = "Allison";
            string herLastName = "Raison";
            string expected = "Adam Raison";
            string actual;
            //act
            customlist.Add(firstName);
            customlist.Add(lastName);
            customlist.Add(herFirstName);
            customlist.Add(herLastName);
            customlist.RemoveRange(1, 2);
            actual = customlist.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveRange_MakeStringCountOne_RemoveFromArray()
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
            customlist.RemoveRange(1, 3);
            actual = customlist.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        /////////////////////////////////////////////////////////
        //Zip_List
        [TestMethod]
        public void Zip_ListOfIntsTogether_StringTogether()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> zipList = new CustomList<int>();
            int numOdd1 = 1;
            int numOdd2 = 3;
            int numOdd3 = 5;
            int numEven1 = 2;
            int numEven2 = 4;
            int numEven3 = 6;
            int expected = 6;
            int actual;
            //act
            odd.Add(numOdd1);
            odd.Add(numOdd2);
            odd.Add(numOdd3);
            even.Add(numEven1);
            even.Add(numEven2);
            even.Add(numEven3);
            zipList = zipList.Zip(even, odd);
            actual = zipList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ListOfIntsTogetherAndChangeCapacity_StringTogether()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> zipList = new CustomList<int>();
            int numOdd1 = 1;
            int numOdd2 = 3;
            int numOdd3 = 5;
            int numEven1 = 2;
            int numEven2 = 4;
            int numEven3 = 6;
            int expected = 8;
            int actual;
            //act
            odd.Add(numOdd1);
            odd.Add(numOdd2);
            odd.Add(numOdd3);
            even.Add(numEven1);
            even.Add(numEven2);
            even.Add(numEven3);
            zipList = zipList.Zip(even, odd);
            actual = zipList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ListOfStringsTogetherAndFindIndice2_StringTogether()
        {
            //arrange
            CustomList<string> odd = new CustomList<string>();
            CustomList<string> even = new CustomList<string>();
            CustomList<string> zipList = new CustomList<string>();
            string wordOne = "Happy";
            string wordTwo = "Birthday";
            string wordThree = "Happy";
            string wordFour = "NewYear";
            string expected = "NewYear";
            string actual;
            //act
            odd.Add(wordOne);
            odd.Add(wordThree);
            even.Add(wordTwo);
            even.Add(wordFour);
            zipList = zipList.Zip(odd, even);
            actual = zipList[3];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ListOfStringsTogetherAndMakeSureCapacityDoubles_StringTogether()
        {
            //arrange
            CustomList<string> odd = new CustomList<string>();
            CustomList<string> even = new CustomList<string>();
            CustomList<string> zipList = new CustomList<string>();
            string wordOne = "Happy";
            string wordTwo = "Birthday";
            string wordThree = "Happy";
            string wordFour = "NewYear";
            string wordFive = "Yes";
            string expected = "Yes";
            string actual;
            //act
            odd.Add(wordOne);
            odd.Add(wordThree);
            even.Add(wordTwo);
            even.Add(wordFour);
            even.Add(wordFive);
            zipList = zipList.Zip(odd, even);
            actual = zipList[4];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ListOfStringsTogetherWithOneStringEmptyAndTheOtherFull_StringTogether()
        {
            //arrange
            CustomList<string> odd = new CustomList<string>();
            CustomList<string> even = new CustomList<string>();
            CustomList<string> zipList = new CustomList<string>();
            string wordOne = "Happy";
            string wordTwo = "Birthday";
            string wordThree = "Happy";
            string wordFour = "NewYear";
            string expected = "NewYear";
            string actual;
            //act
            odd.Add(wordOne);
            odd.Add(wordTwo);
            odd.Add(wordThree);
            odd.Add(wordFour);
            zipList = zipList.Zip(odd, even);
            actual = zipList[3];
            //assert
            Assert.AreEqual(expected, actual);
        }
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
        public void PlusOperator_OverLoadThePlusOperatorWithTwoListsOfInts_CombineIntoOneList()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result1 = new CustomList<int>();
            int numOne = 1;
            int numTwo = 2;
            int numThree = 3;
            int numFour = 4;
            int numFive = 5;
            int numSix = 6;
            string expected = "1 2 3 4 5 6";
            string actual;
            //act
            one.Add(numOne);
            one.Add(numTwo);
            one.Add(numThree);
            two.Add(numFour);
            two.Add(numFive);
            two.Add(numSix);
            result1 = one + two;
            actual =  result1.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOperator_OverLoadThePlusOperatorWithTwoListsOfStrings_CombineIntoOneList()
        {
            //arrange
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();
            CustomList<string> result2 = new CustomList<string>();
            string oneLetter = "A";
            string twoLetter = "B";
            string threeLetter = "C";
            string fourLetter = "D";
            string fiveLetter = "E";
            string sixLetter = "F";
            string expected = "A B C D E F";
            string actual;
            //act
            one.Add(oneLetter);
            one.Add(twoLetter);
            one.Add(threeLetter);
            two.Add(fourLetter);
            two.Add(fiveLetter);
            two.Add(sixLetter);
            result2 = one + two;
            actual = result2.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOperator_OverLoadThePlusOperatorWithTwoListsOneListWithNothingInIt_CombineIntoOneList()
        {
            //arrange
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();
            CustomList<string> result2 = new CustomList<string>();
            string oneLetter = "A";
            string twoLetter = "B";
            string threeLetter = "C";
            string fourLetter = "D";
            string fiveLetter = "E";
            string sixLetter = "F";
            string expected = "A B C D E F";
            string actual;
            //act
            one.Add(oneLetter);
            one.Add(twoLetter);
            one.Add(threeLetter);
            one.Add(fourLetter);
            one.Add(fiveLetter);
            one.Add(sixLetter);
            result2 = one + two;
            actual = result2.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOperator_OverLoadThePlusOperatorWithTwoListsOneAndCheckIndiceOfLetter_CombineIntoOneList()
        {
            //arrange
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();
            CustomList<string> result2 = new CustomList<string>();
            string oneLetter = "A";
            string twoLetter = "B";
            string threeLetter = "C";
            string fourLetter = "D";
            string fiveLetter = "E";
            string sixLetter = "F";
            string expected = "F";
            string actual;
            //act
            one.Add(oneLetter);
            one.Add(twoLetter);
            one.Add(threeLetter);
            two.Add(fourLetter);
            two.Add(fiveLetter);
            two.Add(sixLetter);
            result2 = one + two;
            actual = result2[5];
            //assert
            Assert.AreEqual(expected, actual);
        }
        /////////////////////////
        //Overload - Operator
        [TestMethod]
        public void MinusOperator_OverLoadTheMinusOperatorWithTwoListsOfInts_CombineIntoOneList()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result1 = new CustomList<int>();
            int numOne = 1;
            int numTwo = 3;
            int numThree = 5;
            int numFour = 2;
            int numFive = 1;
            int numSix = 6;
            string expected = "3 5";
            string actual;
            //act
            one.Add(numOne);
            one.Add(numTwo);
            one.Add(numThree);
            two.Add(numFour);
            two.Add(numFive);
            two.Add(numSix);
            result1 = one - two;
            actual = result1.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOperator_OverLoadTheMinusOperatorWithTwoListsOfStrings_CombineIntoOneList()
        {
            //arrange
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();
            CustomList<string> result1 = new CustomList<string>();
            string wordOne = "Work";
            string wordTwo = "School";
            string expected = "School Work";
            string actual;
            //act
            one.Add(wordOne);
            one.Add(wordTwo);
            one.Add(wordOne);
            two.Add(wordOne);
            result1 = one - two;
            actual = result1.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOperator_OverLoadTheMinusOperatorWithTwoListsOfStringsLeavingOnlySchoolInList_CombineIntoOneList()
        {
            //arrange
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();
            CustomList<string> result1 = new CustomList<string>();
            string wordOne = "Work";
            string wordTwo = "School";
            string expected = "School";
            string actual;
            //act
            one.Add(wordOne);
            one.Add(wordTwo);
            one.Add(wordOne);
            two.Add(wordOne);
            two.Add(wordOne);
            result1 = one - two;
            actual = result1.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOperator_OverLoadTheMinusOperatorWithTwoListsOfStringsWithNothingAddedToSecondString_NothingShouldBeSubtracted()
        {
            //arrange
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();
            CustomList<string> result1 = new CustomList<string>();
            string wordOne = "Work";
            string wordTwo = "School";
            string expected = "Work School Work";
            string actual;
            //act
            one.Add(wordOne);
            one.Add(wordTwo);
            one.Add(wordOne);
            result1 = one - two;
            actual = result1.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOperator_OverLoadTheMinusOperatorWithTwoListsOfStringsWithTheFirstListContainingMultipleOfTheSameStrings_OnlySubtractingOneString()
        {
            //arrange
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();
            CustomList<string> result1 = new CustomList<string>();
            string wordOne = "Work";
            string wordTwo = "School";
            string expected = "School Work Work Work Work Work";
            string actual;
            //act
            one.Add(wordOne);
            one.Add(wordTwo);
            one.Add(wordOne);
            one.Add(wordOne);
            one.Add(wordOne);
            one.Add(wordOne);
            one.Add(wordOne);
            two.Add(wordOne);
            result1 = one - two;
            actual = result1.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
