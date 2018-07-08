namespace DataStructures.DataStructures
{
    class StackArray<Type>: Stack<Type>
    {
        private int _headPointer;
        private Type[] _nesting;

        const int RESIZE_MULTIPLIER = 2;
        const int STARTING_CAPACITY = 1;

        public StackArray()
        {
            _nesting = new Type[STARTING_CAPACITY];
            _headPointer = 0;
        }

        public void Push(Type newHead)
        {
            if (_headPointer != 0)
            {
                if (_headPointer > _nesting.Length - 1)
                {
                    ResizeAndCopyNestingdArray();
                }
            }
            _nesting[_headPointer] = newHead;
            _headPointer++;
        }

        public Type Pop()
        {
            _headPointer--;
            return _nesting[_headPointer];
        }

        public override string ToString()
        {
            string returnValue = "";
            for (var i = 0; i < _headPointer; i++)
            {
                returnValue += _nesting[i].ToString();
            }
            return returnValue;
        }

        private void ResizeAndCopyNestingdArray()
        {
            var newNesting = new Type[_nesting.Length * RESIZE_MULTIPLIER];
            for (var i = 0; i < _nesting.Length; i++)
            {
                newNesting[i] = _nesting[i];
            }
            _nesting = newNesting;
        }
    }
}
