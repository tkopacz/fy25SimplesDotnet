namespace ClassLibrary1
{
    public class Class1
    {
        public int Add(int a, int b) => a + b;
        public int Add3(int a, int b, int c) => Add(a,b) + c;
        public int Add4(int a, int b, int c, int d) => Add3(a, b, c) + d;
    }
}
