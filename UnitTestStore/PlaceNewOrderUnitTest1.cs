using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestStore
{
    [TestClass()]
    public class PlaceNewOrderUnitTest1 : SqlDatabaseTestClass
    {

        public PlaceNewOrderUnitTest1()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Sales_uspPlaceNewOrderTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Sales_uspPlaceNewOrderTest_PosttestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceNewOrderUnitTest1));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
            this.Sales_uspPlaceNewOrderTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            Sales_uspPlaceNewOrderTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Sales_uspPlaceNewOrderTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            // 
            // Sales_uspPlaceNewOrderTestData
            // 
            this.Sales_uspPlaceNewOrderTestData.PosttestAction = Sales_uspPlaceNewOrderTest_PosttestAction;
            this.Sales_uspPlaceNewOrderTestData.PretestAction = null;
            this.Sales_uspPlaceNewOrderTestData.TestAction = Sales_uspPlaceNewOrderTest_TestAction;
            // 
            // Sales_uspPlaceNewOrderTest_TestAction
            // 
            resources.ApplyResources(Sales_uspPlaceNewOrderTest_TestAction, "Sales_uspPlaceNewOrderTest_TestAction");
            // 
            // Sales_uspPlaceNewOrderTest_PosttestAction
            // 
            Sales_uspPlaceNewOrderTest_PosttestAction.Conditions.Add(notEmptyResultSetCondition1);
            resources.ApplyResources(Sales_uspPlaceNewOrderTest_PosttestAction, "Sales_uspPlaceNewOrderTest_PosttestAction");
            // 
            // notEmptyResultSetCondition1
            // 
            notEmptyResultSetCondition1.Enabled = true;
            notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
            notEmptyResultSetCondition1.ResultSet = 1;
        }

        #endregion


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
        #endregion

        [TestMethod()]
        public void Sales_uspPlaceNewOrderTest()
        {
            SqlDatabaseTestActions testActions = this.Sales_uspPlaceNewOrderTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions Sales_uspPlaceNewOrderTestData;
    }
}
