
namespace FunctionalCodingExercises;

public static class FizzBuzzExercise
{
    public static void FizzBuzz(int number) =>
        Enumerable.Range(1, number).ToList().ForEach(
            x => Console.WriteLine(x % 15 == 0 ? "FizzBuzz" : x % 3 == 0 ? "Fizz" : x % 5 == 0 ? "Buzz" : x.ToString()));
}
