using TaskSystem.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using TaskSystem.Repository;
using TaskSystem.Models.DAL;
using System.Web.Mvc;

namespace TaskSystemTest
{
    
    
    /// <summary>
    ///This is a test class for UserControllerTest and is intended
    ///to contain all UserControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserControllerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for UserController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void UserControllerConstructorTest()
        {
            IUserRepository repository = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(repository);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void DeleteTest()
        {
            IUserRepository repository = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(repository); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Delete(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertOrUpdate
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void InsertOrUpdateTest()
        {
            IUserRepository repository = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(repository); // TODO: Initialize to an appropriate value
            User user = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.InsertOrUpdate(user);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Login
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void LoginTest()
        {
            IUserRepository repository = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(repository); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Login();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Login
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void LoginTest1()
        {
            IUserRepository repository = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(repository); // TODO: Initialize to an appropriate value
            User u = null; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Login(u);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Logout
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void LogoutTest()
        {
            IUserRepository repository = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(repository); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Logout();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShowUser
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void ShowUserTest()
        {
            IUserRepository repository = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(repository); // TODO: Initialize to an appropriate value
            Nullable<int> page = new Nullable<int>(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.ShowUser(page);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UserNameList
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void UserNameListTest()
        {
            IUserRepository repository = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(repository); // TODO: Initialize to an appropriate value
            JsonResult expected = null; // TODO: Initialize to an appropriate value
            JsonResult actual;
            actual = target.UserNameList();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
