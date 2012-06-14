using TaskSystem.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using TaskSystem.Models.DAL;
using System.Linq;

namespace TaskSystemTest
{
    
    
    /// <summary>
    ///This is a test class for TaskRepositoryTest and is intended
    ///to contain all TaskRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TaskRepositoryTest
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
        ///A test for TaskRepository Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void TaskRepositoryConstructorTest()
        {
            TaskEntities context = null; // TODO: Initialize to an appropriate value
            TaskRepository target = new TaskRepository(context);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for All
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void AllTest()
        {
            TaskEntities context = null; // TODO: Initialize to an appropriate value
            TaskRepository target = new TaskRepository(context); // TODO: Initialize to an appropriate value
            Func<Task, bool> func = null; // TODO: Initialize to an appropriate value
            IQueryable<Task> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<Task> actual;
            actual = target.All(func);
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
            TaskEntities context = null; // TODO: Initialize to an appropriate value
            TaskRepository target = new TaskRepository(context); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            target.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Find
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void FindTest()
        {
            TaskEntities context = null; // TODO: Initialize to an appropriate value
            TaskRepository target = new TaskRepository(context); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.Find(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetLastTaskId
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void GetLastTaskIdTest()
        {
            TaskEntities context = null; // TODO: Initialize to an appropriate value
            TaskRepository target = new TaskRepository(context); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetLastTaskId();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTasksByUser
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void GetTasksByUserTest()
        {
            TaskEntities context = null; // TODO: Initialize to an appropriate value
            TaskRepository target = new TaskRepository(context); // TODO: Initialize to an appropriate value
            User u = null; // TODO: Initialize to an appropriate value
            IQueryable expected = null; // TODO: Initialize to an appropriate value
            IQueryable actual;
            actual = target.GetTasksByUser(u);
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
            TaskEntities context = null; // TODO: Initialize to an appropriate value
            TaskRepository target = new TaskRepository(context); // TODO: Initialize to an appropriate value
            Task t = null; // TODO: Initialize to an appropriate value
            target.InsertOrUpdate(t);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void SaveTest()
        {
            TaskEntities context = null; // TODO: Initialize to an appropriate value
            TaskRepository target = new TaskRepository(context); // TODO: Initialize to an appropriate value
            target.Save();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
