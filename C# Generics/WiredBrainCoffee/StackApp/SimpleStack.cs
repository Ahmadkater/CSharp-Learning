using System ; 

namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack
    {
        private readonly Object[] _items;
        private int _currentIndex = -1 ;

        public int count => _currentIndex + 1 ;

        public SimpleStack() => _items = new Object[10] ;

        public void Push(Object item) => _items[++_currentIndex] = item ;

        public Object Pop() =>
            _items [_currentIndex --] ;

    }
}