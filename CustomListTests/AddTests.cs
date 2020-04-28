﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(10);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrementsisone()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        [TestMethod]
        public void Add_AddingMultipleValuesToCustomList_AddedValueGoesToIndexThree()
        { // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 10;
            int itemToAdd2 = 6;
            int itemToAdd3 = 45;
            int itemToAdd4 = 25;
            int expected = 45;
            int actual;

            // act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            actual = testList[3];
            // assert
            Assert.AreEqual(expected, actual);



        }



        // what happens to the last-added item?

        [TestMethod]
        public void Add_AddingMultipleValuesToCustomList_IndexOfLastItemIsThree()
        { // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 40;
            int itemToAdd2 = 35;
            int itemToAdd3 = 85;
            int itemToAdd4 = 90;
            int expected = 90;
            int actual;

            // act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            actual = testList[3];

            // assert
            Assert.AreEqual(expected, actual);


        }

        // what happens to the Count?
        [TestMethod]

        public void Add_AddingMultipleValuesToCustomList_CountofCustomListIncrementsIsFour()
        { // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 40;
            int itemToAdd2 = 35;
            int itemToAdd3 = 85;
            int itemToAdd4 = 70;
            int expected = 4;
            int actual;

            // act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }


        // what happens if you add more items than the initial Capacity of the CustomList?
        [TestMethod]
        public void Add_AddingMultipleValuesToCustomList_CapacityOfCustomList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 87;
            int itemToAdd2 = 78;
            int itemToAdd3 = 98;
            int itemToAdd4 = 25;
            int itemToAdd5 = 98;
            int expected = 8;
            int actual;

            // act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            testList.Add(itemToAdd5);
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);

        }
    }    

        
}
