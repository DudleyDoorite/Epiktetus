using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Epik.EpisodeManager.Workflow;
using System.Configuration;

namespace UnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        #region Session_Region
        [TestMethod]
        public void Test_Session_Creation()
        {
            Session mySession = new Session();
            Assert.IsInstanceOfType(mySession, typeof(Session));
        }

        [TestMethod]
        public void Test_Session_Name()
        {
            string target = "Unit TestSession";
            Session mySession = new Session() {  Name = target};
            string actual = mySession.Name;
            Assert.IsTrue(actual == target);
            
        }

        [TestMethod]
        public void Test_Session_AddStep()
        {
            Session mySession = new Session() { Name = "Unit TestSession" };
            
        }

        [TestMethod]
        public void Test_Session_RemoveStep()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void Test_Session_AddStepFileMove()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void Test_Session_RemoveStepFileMove()
        {
            Assert.Inconclusive();
        }
        #endregion
        #region StepFileMove_Region
        [TestMethod]
        public void Test_Session_Create_StepFileMove()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void Test_Session_StepFileMove_Input()
        {
            Assert.Inconclusive();
        }
        public void Test_Session_StepFileMove_Output()
        {
            Assert.Inconclusive();
        }
        public void Test_Session_StepFileMove_Copy()
        {
            Assert.Inconclusive();
        }
        public void Test_Session_StepFileMove_Move()
        {
            Assert.Inconclusive();
        }
        public void Test_Session_StepFileMove_Overwrite()
        {
            Assert.Inconclusive();
        }
        #endregion

    }
}
