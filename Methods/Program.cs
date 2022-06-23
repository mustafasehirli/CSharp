namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();

            var method = Add2(10, 20);
            Console.WriteLine(method);

            var method2 = Add3(20, 30);
            Console.WriteLine(method2);


            Console.WriteLine(Multiply(50, 100));
            Console.WriteLine(Multiply(100, 200, 300));
        }

        static void Add()
        {
            Console.WriteLine("Methods");
        }

        static int Add2(int num1, int num2)
        {
            return num1 + num2;
        }


        static int Add3(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Multiply(int number, int number2)
        {
            return number * number2;
        }
        static int Multiply(int number, int number2, int number3)
        {
            return number * number2 * number3;
        }

    }

}