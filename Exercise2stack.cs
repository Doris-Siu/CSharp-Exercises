using System;
namespace CSharp_stopWatchExercise
{
	public class Exercise2stack
	{
		public  void Exercise2()
		{
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //stack.Clear();

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
	}
}

