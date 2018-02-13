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
            mySession.AddaStep("title", Epik.EpisodeManager.Workflow.Steps.StepTypes.FileMover);
            Assert.IsTrue(mySession.Steps.Count == 1);
        }

        [TestMethod]
        public void Test_Session_RemoveStep()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void Test_Session_AddStepFileMove()
        {
            Session mySession = new Session() { Name = "Unit TestSession" };
            mySession.AddaStep("title", Epik.EpisodeManager.Workflow.Steps.StepTypes.FileMover);
            Assert.IsTrue(mySession.StepFileMovers.Count == 1);
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
            Epik.EpisodeManager.Workflow.Steps.StepFileMove sfm = new Epik.EpisodeManager.Workflow.Steps.StepFileMove();
            Assert.IsInstanceOfType(sfm, typeof(Epik.EpisodeManager.Workflow.Steps.StepFileMove));
        }
        [TestMethod]
        public void Test_Session_StepFileMove_Input()
        {
            string target = @"C:\dev\test.txt";
            Epik.EpisodeManager.Workflow.Steps.StepFileMove sfm = new Epik.EpisodeManager.Workflow.Steps.StepFileMove() {  InputFile = target};
            string actual = sfm.InputFile;
            Assert.IsTrue(actual == target);
        }
        [TestMethod]
        public void Test_Session_StepFileMove_Output()
        {
            string target = @"C:\dev\test.txt";
            Epik.EpisodeManager.Workflow.Steps.StepFileMove sfm = new Epik.EpisodeManager.Workflow.Steps.StepFileMove() { Output = target};
            string actual = sfm.Output;
            Assert.IsTrue(actual == target);
        }
        [TestMethod]
        public void Test_Session_StepFileMove_Copy()
        {
            bool target = true;
            Epik.EpisodeManager.Workflow.Steps.StepFileMove sfm = new Epik.EpisodeManager.Workflow.Steps.StepFileMove() { Copy = true};
            bool actual = sfm.Copy;
            Assert.IsTrue(actual == target);
        }
        [TestMethod]
        public void Test_Session_StepFileMove_Move()
        {
            bool target = false;
            Epik.EpisodeManager.Workflow.Steps.StepFileMove sfm = new Epik.EpisodeManager.Workflow.Steps.StepFileMove() { Copy = false };
            bool actual = sfm.Copy;
            Assert.IsTrue(actual == target);
        }
        [TestMethod]
        public void Test_Session_StepFileMove_Overwrite()
        {
            bool target = true;
            Epik.EpisodeManager.Workflow.Steps.StepFileMove sfm = new Epik.EpisodeManager.Workflow.Steps.StepFileMove() {  Overwite = true};
            bool actual = sfm.Overwite;
            Assert.IsTrue(actual == target);
        }
        #endregion

    }
}
