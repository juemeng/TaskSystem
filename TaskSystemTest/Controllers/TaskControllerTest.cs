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
    ///This is a test class for TaskControllerTest and is intended
    ///to contain all TaskControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TaskControllerTest
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
        ///A test for TaskController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void TaskControllerConstructorTest()
        {
            ITaskRepository taskrepository = null; // TODO: Initialize to an appropriate value
            IUserRepository userrepository = null; // TODO: Initialize to an appropriate value
            TaskController target = new TaskController(taskrepository, userrepository);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void AddTest()
        {
            ITaskRepository taskrepository = null; // TODO: Initialize to an appropriate value
            IUserRepository userrepository = null; // TODO: Initialize to an appropriate value
            TaskController target = new TaskController(taskrepository, userrepository); // TODO: Initialize to an appropriate value
            Task t = null; // TODO: Initialize to an appropriate value
            JsonResult expected = null; // TODO: Initialize to an appropriate value
            JsonResult actual;
            actual = target.Add(t);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            ITaskRepository taskrepository = null; // TODO: Initialize to an appropriate value
            IUserRepository userrepository = null; // TODO: Initialize to an appropriate value
            TaskController target = new TaskController(taskrepository, userrepository); // TODO: Initialize to an appropriate value
            int taskid = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Delete(taskid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Index
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void IndexTest()
        {
            ITaskRepository taskrepository = null; // TODO: Initialize to an appropriate value
            IUserRepository userrepository = null; // TODO: Initialize to an appropriate value
            TaskController target = new TaskController(taskrepository, userrepository); // TODO: Initialize to an appropriate value
            Nullable<int> page = new Nullable<int>(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Index(page);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void UpdateTest()
        {
            ITaskRepository taskrepository = null; // TODO: Initialize to an appropriate value
            IUserRepository userrepository = null; // TODO: Initialize to an appropriate value
            TaskController target = new TaskController(taskrepository, userrepository); // TODO: Initialize to an appropriate value
            Task t = null; // TODO: Initialize to an appropriate value
            JsonResult expected = null; // TODO: Initialize to an appropriate value
            JsonResult actual;
            actual = target.Update(t);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
