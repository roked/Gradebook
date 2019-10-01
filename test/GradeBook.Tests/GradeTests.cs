using Xunit;

namespace GradeBook.Tests
{
    public class GradeTests
    {
        [Fact]
        public void GradeValueIsMore()
        {
            var book = new InMemoryBook("Book 1");
            //book.AddGrade(101);

            var number = book.GetStatistics();

            var result = double.MinValue;
            Assert.Equal(result, number.High);
        }
    }
}