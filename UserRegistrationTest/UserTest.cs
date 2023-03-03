using UserRegistrationUsingMSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
    
namespace UserRegistrationUsingMSTest
{
    [TestClass]
    public class UserTest
    {
            [TestMethod]
            [DataRow(new string[] {"Keerti" ,"Keerti"}, true)]
            [DataRow(new string[] {"kee" ,"ki"}, false)]
            public void ValidFirstName(string[] arr, bool expected)
            {
                //Arrange
                CheckValidOrInvalid check = new CheckValidOrInvalid();
                foreach (string data in arr)
                {
                    bool actual = check.ValidFirstName(data);
                    //Assert
                    Assert.AreEqual(actual, expected);
                }
            }


           [TestMethod]
           [DataRow(new string[] {"Kakhani", "Kakhani" }, true)]
           [DataRow(new string[] { "kakh","ka" }, false)]
           public void ValidLastName(string[] arr, bool expected)
           {
              CheckValidOrInvalid check = new CheckValidOrInvalid();
               foreach (string data in arr)
               {
                  bool actual = check.ValidLastName(data);
                  Assert.AreEqual(actual, expected);
               }
           }
    }
}