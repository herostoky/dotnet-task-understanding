// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

namespace TaskUnderstanding
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            FormattableString formattableString = $"hello{"test"}";
            Console.WriteLine(formattableString.ArgumentCount);

            var stringInterpolation = $"hello{formattableString}";
            FormattableString formattableStringNotSafe = FormattableStringFactory.Create(stringInterpolation);
            Console.WriteLine(formattableStringNotSafe.ArgumentCount);
            // FormattableString formattableStringNotSafe = stringInterpolation;
            return;

            Console.WriteLine("Hello, World!");

            Task<int> testTask = new Task<int>(GetRandomNumber);

            // testTask.Wait();
            var testResult = await testTask;
            Console.WriteLine($"Result is here {testResult}");
        }
        static int GetRandomNumber()
        {
            Console.WriteLine("Sleep 1 second first ...");
            Thread.Sleep(1000);
            Console.WriteLine("GetRandomNumber now ...");
            var randomNumber = new System.Random().Next(2);
            Console.WriteLine($"Got RandomNumber [{randomNumber}]");
            return randomNumber;
        }
    }
}