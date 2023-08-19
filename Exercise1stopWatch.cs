using System;
namespace CSharp_Exercises
{
	public class Exercise1stopWatch
	{
		public  void Exercise1()
		{
            var stopwatch = new Stopwatch();

            while (true)
            {
                stopwatch.Start();
                Thread.Sleep(2000);
                stopwatch.Stop();


                Console.WriteLine("The duration between start and stop is " + stopwatch.GetDuration());
                Console.Write("Press Enter to continue: ");
                Console.ReadLine();


            }
        }
	}
}

