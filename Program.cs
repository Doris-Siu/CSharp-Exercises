// See https://aka.ms/new-console-template for more information

using CSharp_stopWatchExercise;

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
