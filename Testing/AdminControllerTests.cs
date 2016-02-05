using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectronicManager.Web.Models;
using System.Collections.Generic;
using System.Linq;
using ElectronicManager.Web.Controllers;

namespace Testing
{
    [TestClass]
    public class AdminControllerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange (set up a scenario)
            User user = new User() { LoginName = "Sean" };
            FakeRepository repositoryParam = new FakeRepository();
            repositoryParam.Add(user);
            AdminController target = new AdminController(repositoryParam);
            string oldLoginParam = user.LoginName;
            string newLoginParam = "Joe";

            // Act
            target.ChangeLoginName(oldLoginParam, newLoginParam);

            // Assert 
            Assert.AreEqual(newLoginParam, user.LoginName);
            Assert.IsTrue(repositoryParam.DidSubmitChanges);

        }
    }

    class FakeRepository : IUserRepository
    {
        public List<User> Users = new List<User>();
        public bool DidSubmitChanges = false;

        public void Add(User user)
        {
            Users.Add(user);
        }

        public User FetchByLoginName(string loginName)
        {
            return Users.First(m => m.LoginName == loginName);
        }

        public void SubmitChanges()
        {
            DidSubmitChanges = true;
        }
    }
}
