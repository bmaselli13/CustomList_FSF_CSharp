using CustomList;

namespace CustomListTests;

[TestClass]
public class SubMethodTests
{

    [TestMethod]
    public void RemoveMethod_ItemRemoved_CountDecrements_CountDecrementsWhenItemRemoved()
    {
        // Arrange
        CustomList<int> myList = new CustomList<int>();
        int expected = 2;
        int actual;

        // Act
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Remove(1);
        actual = list.Count;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RemoveMethod_MethodReturnsTrueIfItemRemovedTest_MethodReturnsTrue()
    {
        //ARRANGE
        CustomList<int> myList = new CustomList<int>();
        int expected = 1;
        int actual;

        //ACT
        myList.Add(1);
        myList.Remove(1);
        actual = myList.Count;

        //ASSERT
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RemoveMethod_CountDoesNotDecrementIfItemIsNotInList_CountWillNotDecrement()
    {
        //ARRANGE
        CustomList<int> myList = new CustomList<int>();
        int expected = 1;
        int actual;

        //ACT
        myList.Add(1);
        myList.Remove(1);
        actual = myList.Count;

        //ASSERT
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RemoveMethod_ItemsShiftsBackwardAfterRemoval_ItemsWillShiftBackwards()
    {
        // Remove item 3 at index 2
        // Arrange
        int[] myList = { 1, 2, 3, 4, 5 };
        int indexToRemove = 2; 

        // Act
        myList.ArrayUtils.RemoveAndShiftBackwards(myList, indexToRemove);

        // Assert
        // Item 3 is removed, and subsequent items are shifted back
        int[] expectedArray = { 1, 2, 4, 5 }; 
        Assert.AreEqual(expectedArray, myList);
    }




}


