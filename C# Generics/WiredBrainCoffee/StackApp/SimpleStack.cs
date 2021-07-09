using System ;

namespace WiredBrainCoffee.StackApp
{
    public class SimpleStackdouble
    {
        private readonly double[] _items;
        private int _currentIndex = -1 ;

        public int count => _currentIndex + 1 ;

        public SimpleStackdouble() => _items = new double[10] ;

        public void Push(double item) => _items[++_currentIndex] = item ;

        public double Pop() =>
            _items [_currentIndex --] ;

    }
    public class SimpleStackString
    {
        private readonly string[] _items;
        private int _currentIndex = -1 ;

        public int count => _currentIndex + 1 ;

        public SimpleStackString() => _items = new string[10] ;

        public void Push(string item) => _items[++_currentIndex] = item ;

        public string Pop() =>
            _items [_currentIndex --] ;

    }
}