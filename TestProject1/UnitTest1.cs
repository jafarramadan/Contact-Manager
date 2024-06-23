using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestProject1
{
    public class UnitTest1
    {
        // Add Case
        [Fact]
        public void AddCase()
        {
            // Arrange
            string Action = "add";
            List<string> Contact = new List<string>
        {
            "Ali",
             "Khaled",
             "Sara"
        };
            string CName = "Roaa";


            // Act
            List<string> result = Contact_Manager.Program.ContactsManager( Contact, Action, CName);
            // Assert
            Assert.Equal(4, result.Count);
        }


        [Fact]
        public void AddRejected()
        {
            // Arrange
            string Action = "add";
            List<string> Contact = new List<string>
        {
            "Ali",
             "Ahmad",
             "Sara"
        };
            string CName = "Ali";

            // Act
            List<string> result = Contact_Manager.Program.ContactsManager(Contact, Action,  CName);
            // Assert
            Assert.Equal(3, result.Count);
        }


        // Remove Case 
        [Fact]
        public void RemoveCase()
        {
            // Arrange
            string Action = "remove";
            List<string> Contact = new List<string>
        {
            "Ali",
             "Ahmad",
             "Sara"
        };
            string CName = "Ali";

            // Act
            List<string> result = Contact_Manager.Program.ContactsManager(Contact, Action,  CName);

            // Assert
            Assert.Equal(2, result.Count);
        }


        // ViewAll Case
        [Fact]
        public void ViewAllCase()
        {
            // Arrange
            string Action = "view";
            List<string> Contact = new List<string>
        {
            "Ali",
             "Ahmad",
             "Sara"
        };
            // Act
            List<string> result = Contact_Manager.Program.ContactsManager(Contact,Action);
            // Assert
            Assert.Equal(3, result.Count);
        }
    }
}