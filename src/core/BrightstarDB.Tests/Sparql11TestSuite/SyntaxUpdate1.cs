using NUnit.Framework;

namespace BrightstarDB.Tests.Sparql11TestSuite {
    
	public partial class SyntaxUpdate1 : SparqlTest {

        public SyntaxUpdate1() : base()
        {
            
        }

		[SetUp]
		public void SetUp()
		{
			CreateStore();
		    
		}

        [TearDown]
        public void TearDown()
        {
			DeleteStore();
            
        }

		#region Test Methods

		#endregion

		
	}
}