using NUnit.Framework;

namespace BrightstarDB.Tests.Sparql11TestSuite {
	public partial class SyntaxFed : SparqlTest {

        public SyntaxFed() : base()
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