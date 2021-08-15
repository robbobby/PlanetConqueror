using Xunit;
namespace TestProject1 {
    public class TestingExamples {
        
        
        // multiple tests
        [Theory]
        [InlineData(13, 5, 8)]
        [InlineData(0, -3, 3)]
        [InlineData(0, 0, 0)]
        public void AddTwoNumbersAndGetResukt(int expectedResult, int firstToAdd, int secondToAdd ) {
            // someCalculator.Add(firstToAdd)
            // someCalculator.Add(secondToAdd)
            // Assert.Equal(expectedResult, someCalcultor.Value);
        }

        [Fact(Skip = "Comment for reason to skip this test")]
        public void TestToSkip() {
            Assert.Equal(1, 0);
        }
    }
}
