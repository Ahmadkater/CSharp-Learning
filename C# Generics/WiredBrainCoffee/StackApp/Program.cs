namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)        
        {
            doubleStack();
            stringStack();
        }

        public static void doubleStack()       
        {
            var s = new SimpleStack();
            s.Push(25.0);
            s.Push(75.0);
            s.Push(100.0);

            while (s.count > 0)
            {
                var item = s.Pop();

                System.Console.WriteLine(item);
            }
        }

        public static void stringStack()       
        {
            var s = new SimpleStack();
            s.Push("p1");
            s.Push("p2");
            s.Push("p3");

            while (s.count > 0)
            {
                var item = s.Pop();

                System.Console.WriteLine(item);
            }
        }
    }
}
