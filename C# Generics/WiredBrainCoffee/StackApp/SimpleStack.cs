namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack 
    {
        private readonly double[] _items;
        private int _currentIndex = -1 ;

        public int count => _currentIndex + 1 ;

        public SimpleStack() => _items = new double[10] ; 

        public void Push(double item) => _items[++_currentIndex] = item ;

        public double Pop() => 
            _items [_currentIndex --] ;
        
    }
}