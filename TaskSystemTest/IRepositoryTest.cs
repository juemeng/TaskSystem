using TaskSystem.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Linq;

namespace TaskSystemTest
{
    
    
    /// <summary>
    ///This is a test class for IRepositoryTest and is intended
    ///to contain all IRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IRepositoryTest
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
        ///A test for InsertOrUpdate
        ///</summary>
        public void InsertOrUpdateTestHelper<T>()
        {
            IRepository<T> target = CreateIRepository<T>(); // TODO: Initialize to an appropriate value
            T t = default(T); // TODO: Initialize to an appropriate value
            target.InsertOrUpdate(t);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        internal virtual IRepository<T> CreateIRepository<T>()
        {
            // TODO: Instantiate an appropriate concrete class.
            IRepository<T> target = null;
            return target;
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void InsertOrUpdateTest()
        {
            InsertOrUpdateTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Find
        ///</summary>
        public void FindTestHelper<T>()
        {
            IRepository<T> target = CreateIRepository<T>(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = target.Find(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void FindTest()
        {
            FindTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        public void DeleteTestHelper<T>()
        {
            IRepository<T> target = CreateIRepository<T>(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            target.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void DeleteTest()
        {
            DeleteTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for All
        ///</summary>
        public void AllTestHelper<T>()
        {
            IRepository<T> target = CreateIRepository<T>(); // TODO: Initialize to an appropriate value
            Func<T, bool> func = null; // TODO: Initialize to an appropriate value
            IQueryable<T> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<T> actual;
            actual = target.All(func);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void AllTest()
        {
            AllTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        public void SaveTestHelper<T>()
        {
            IRepository<T> target = CreateIRepository<T>(); // TODO: Initialize to an appropriate value
            target.Save();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\zoul\\documents\\visual studio 2010\\Projects\\TaskSystem\\TaskSystem", "/")]
        [UrlToTest("http://localhost:5313/")]
        public void SaveTest()
        {
            SaveTestHelper<GenericParameterHelper>();
        }
    }
}
