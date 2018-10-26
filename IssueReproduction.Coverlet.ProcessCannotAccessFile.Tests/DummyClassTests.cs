using Xunit;

namespace IssueReproduction.Coverlet.ProcessCannotAccessFile.Tests
{
    public class DummyClassTests
    {
        [Fact]
        public void DummyMethod_ReturnsString()
        {
            var dummy = new DummyClass();
            const string dummyString = "dummyString";

            Assert.Equal(dummyString, dummy.DummyMethod(dummyString));
        }
    }
}
