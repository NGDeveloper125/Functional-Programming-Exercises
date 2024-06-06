
namespace FunctionalCodingExercises;

public static class FuzzBuzzExercise
{
    public static void FuzzBuzz(int number) =>
        Enumerable.Range(1, number).ToList().ForEach(
            x => Console.WriteLine(x % 15 == 0 ? "FuzzBuzz" : x % 3 == 0 ? "Fuzz" : x % 5 == 0 ? "Buzz" : x.ToString()));
}
