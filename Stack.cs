using System;
namespace CSharp_Exercises
{
	public class Stack


	{
        private readonly List<object> _stack;

        public Stack()
		{
			_stack = new List<object>();
		}

		public void Push(object obj)
		{
			if (obj == null)
			{
				throw new InvalidOperationException("null is passed to this object.");
			};

			_stack.Add(obj);

		}

		public object Pop()
		{
			if (_stack.Count == 0)
			{
				throw new InvalidOperationException("An empty stack.");

			}

			var index = _stack.Count - 1;
			var result = _stack[index];

			_stack.RemoveAt(index);

			return result;

		}

		public void Clear()
		{
			_stack.Clear();

		}
	}
}

