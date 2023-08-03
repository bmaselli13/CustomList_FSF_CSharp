using CustomList;

namespace CustomListTests;

[TestClass]
public class AddMethodTests 
{
    [TestMethod]
    public void AddMethod_AddTwoItems_CountItems()
    {

        //ARRANGE
        CustomList<int> myList = new CustomList<int>();

        //ACT
        myList.Add(1);
        

        //ASSERT
        Assert.AreEqual(1, myList.Count);
    }

    [TestMethod]
    public void AddMethod_ItemAtZeroIndex_ItemAtZeroIndexIsVerified()
    {

        //ARRANGE
        CustomList<int> myList = new CustomList<int>();

        //ACT
        myList.Add(1);


        //ASSERT
        Assert.AreEqual(1, myList[0]);
    }

    [TestMethod]
    public void AddMethod_AddSecondItemToOneIndex_SecondItemAddedInOneIndex()
    {

        //ARRANGE
        CustomList<int> myList = new CustomList<int>();

        //ACT
        myList.Add(1);
        myList.Add(2);


        //ASSERT
        Assert.AreEqual(2, myList[1]);
    }

    [TestMethod]
    public void AddMethod_IncreaseCapactity_CapacityIncreasesWhenIndexExceeded()
    {

        //ARRANGE
        CustomList<int> myList = new CustomList<int>();
        int capacity = 4;

        //ACT
        for (int i = 0; i < capacity + 1; i++ )
        {
            myList.Add(i);
        }


        //ASSERT
        Assert.AreEqual(8, myList.Capacity); //Use capacity method to check number of elements the list can contain
    }

    [TestMethod]
    public void AddMethod_OriginalItemsPersisted_OriginalItemsPersistedAfterIncrease()
    {

        //ARRANGE
        CustomList<int> myList = new CustomList<int>();
        int capacity = 4;

        //ACT
        for (int i = 0; i < capacity + 1; i++)
        {
            myList.Add(i);
        }


        //ASSERT
        for (int i = 0; i < capacity; i++)
        {
            Assert.AreEqual(i, myList[i]); // Check if the original items persist in the same index
        }
    }


}
