namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AlwaysFail()
        {
            Assert.Equal(1, 2);
        }
        [Fact]
        public void AlwaysOK()
        {
            Assert.Equal(1, 1);
        }


    }
}