using Xunit;

namespace GradeBook.Tests
{
    public class GradeTests
    {
        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }
    }
}