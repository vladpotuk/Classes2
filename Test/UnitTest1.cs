using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

[TestClass]
public class Tests
{
    [TestClass]
    public class JournalTests
    {
        [TestMethod]
        public void TestJournalOperations()
        {
            // Arrange
            Journal journal1 = new Journal();
            journal1.NumberOfEmployees = 100;

            Journal journal2 = new Journal();
            journal2.NumberOfEmployees = 150;

            // Act
            Journal resultJournalAdd = journal1 + 50;
            Journal resultJournalSubtract = journal2 - 100; 

            // Assert
            Assert.AreEqual(150, resultJournalAdd.NumberOfEmployees); 
            Assert.AreEqual(50, resultJournalSubtract.NumberOfEmployees);
        }
    }

    [TestClass]
    public class ShopTests
    {
        [TestMethod]
        public void TestShopOperations()
        {
            // Arrange
            Shop shop1 = new Shop();
            shop1.Area = 100;

            Shop shop2 = new Shop();
            shop2.Area = 150;

            // Act
            Shop resultShopAdd = shop1 + 50; 
            Shop resultShopSubtract = shop2 - 100; 

            // Assert
            Assert.AreEqual(150, resultShopAdd.Area);
            Assert.AreEqual(50, resultShopSubtract.Area); 
        }
    }

    [TestClass]
    public class ReadingListTests
    {
        [TestMethod]
        public void TestReadingListOperations()
        {
            // Arrange
            ReadingList list = new ReadingList();
            list.AddBook("Book1");
            list.AddBook("Book2");
            list.AddBook("Book3");

            // Act & Assert
            Assert.IsTrue(list.ContainsBook("Book1")); 
            Assert.IsFalse(list.ContainsBook("Book4")); 

            list.RemoveBook("Book2");
            Assert.IsFalse(list.ContainsBook("Book2")); 
        }
    }
}
