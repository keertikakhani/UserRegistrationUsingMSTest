using UserRegistrationUsingMSTest; 
    
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
    }
}