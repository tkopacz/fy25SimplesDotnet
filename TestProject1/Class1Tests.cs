using Xunit;

namespace TestProject1
{
    public class Class1Tests
    {
        private readonly ClassLibrary1.Class1 _class1;

        public Class1Tests()
        {
            _class1 = new ClassLibrary1.Class1();
        }

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 10;

            // Act
            int result = _class1.Add(a, b);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Add3_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int c = 15;

            // Act
            int result = _class1.Add3(a, b, c);

            // Assert
            Assert.Equal(30, result);
        }

        [Fact]
        public void Add4_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int c = 15;
            int d = 20;

            // Act
            int result = _class1.Add4(a, b, c, d);

            // Assert
            Assert.Equal(50, result);
        }
    }
}
