using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests
  {
    Item newItem = new Item();

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Assert.AreEqual(typeof(Item), newItem.GetType()); 
    }
    
  }
}